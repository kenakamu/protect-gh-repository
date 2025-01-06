namespace ghwebhook;

/// <summary>
/// GitHubWebhookEventProcessor that processes all GitHub webhook events.
/// </summary>
/// <param name="gitHubClient">GitHubClient for GitHhub API operation</param>
/// <param name="logger">ILogger</param>
public class GitHubWebhookEventProcessor(GitHubClient gitHubClient, ILogger<GitHubWebhookEventProcessor> logger) : WebhookEventProcessor
{
    private readonly GitHubClient gitHubClient = gitHubClient;
    private readonly ILogger<GitHubWebhookEventProcessor> logger = logger;
    private readonly string gitHubUserName = Environment.GetEnvironmentVariable("GitHubUserName")!;

    /// <summary>
    /// Handle the repository event.
    /// </summary>
    /// <param name="headers">WebhookHeaders</param>
    /// <param name="repositoryEvent">RepositoryEvent</param>
    /// <param name="action">RepositoryAction</param>
    /// <returns></returns>
    protected override async Task ProcessRepositoryWebhookAsync(WebhookHeaders headers, RepositoryEvent repositoryEvent, RepositoryAction action)
    {
        switch (action)
        {
            case RepositoryActionValue.Created:
                logger.LogInformation("Repository create event.");

                if (repositoryEvent.Organization is null || repositoryEvent.Repository is null)
                {
                    logger.LogError("Organization or Repository is null");
                    return;
                }

                string organizationName = repositoryEvent.Organization.Login;
                string repositoryName = repositoryEvent.Repository.Name;
                long repositoryId = repositoryEvent.Repository.Id;

                bool ruleSetCreated = false;
                bool defaultSetupConfigured = false;
                bool secretScanningEnabled = false;

                try
                {
                    // Create a ruleset for the repository to protect main (default) branch(es).
                    RuleSet ruleSet = new()
                    {
                        Owner = organizationName,
                        Repo = repositoryName,
                        Name = "MyRuleSet",
                        Target = TargetType.branch,
                        Enforcement = RuleEnforcement.active,
                        Conditions = new()
                        {
                            RefName = new()
                            {
                                Include = new() { "~DEFAULT_BRANCH" }
                            }
                        },
                        Rules = new()
                        {
                            new DeletionRule(),
                            new PullRequestRule()
                            {
                                Parameters = new()
                                {
                                    RequiredApprovingReviewCount=2,
                                    RequiredReviewThreadResolution = true,
                                    AllowedMergeMethods = new() { "squash", "merge" }
                                }
                            }
                        }
                    };

                    await gitHubClient.Connection.Post<RuleSet>(
                        new Uri($"repositories/{repositoryId}/rulesets", UriKind.Relative),
                        ruleSet,
                        "application/json",
                        "application/json");

                    ruleSetCreated = true;
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "Failed to create ruleset.");
                }

                try
                {
                    DefaultSetup defaultSetup = new()
                    {
                        State = DefaultSetupStateType.Configured 
                    };
                    await gitHubClient.Connection.Patch<DefaultSetup>(
                        new Uri($"repositories/{repositoryId}/code-scanning/default-setup", UriKind.Relative),
                        defaultSetup,
                        "application/json");

                    defaultSetupConfigured = true;
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "Failed to configure default setup.");
                }

                try
                {
                    // Enable Secret Scanning 
                    Repository updated = await gitHubClient.Repository.Edit(
                        repositoryId, 
                        new() 
                        {
                            SecurityAndAnalysis = new()
                            {
                                SecretScanning = new()
                                {
                                    Status = Status.Enabled
                                },
                                SecretScanningPushProtection = new()
                                {
                                    Status = Status.Enabled
                                }
                            }
                        });

                    secretScanningEnabled = true;
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "Failed to enable secret scanning.");
                }

                try
                {
                    // Create an issue to notify user.
                    StringBuilder issueBody = new();
                    issueBody.AppendLine($"Hi @{gitHubUserName},\n");
                    issueBody.AppendLine(ruleSetCreated ? "Ruleset has been created successfully.\n" : "Failed to create ruleset.\n");
                    issueBody.AppendLine(defaultSetupConfigured ? "Default setup has been configured successfully.\n" : "Failed to configure default setup.\n");
                    issueBody.AppendLine(secretScanningEnabled ? "Secret scanning has been enabled successfully.\n" : "Failed to enable secret scanning.\n");

                    NewIssue issue = new("Repository setup status")
                    {
                        Body = issueBody.ToString()
                    };
                    await gitHubClient.Issue.Create(repositoryId, issue);
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "Failed to create issue.");
                }
                break;
            default:
                logger.LogInformation("Some other repository event");
                await Task.Delay(1000);
                break;
        }
    }
}
