
int gitHubApplicationId = int.Parse(Environment.GetEnvironmentVariable("GitHubApplicationId")!);
string gitHubApplicationPemFilePath = Environment.GetEnvironmentVariable("GitHubApplicationPemFilePath")!;

// Create a JWT token for the GitHubApp by using AppId and pem file.
GitHubJwtFactory generator = new(
    new FilePrivateKeySource(gitHubApplicationPemFilePath),
    new GitHubJwtFactoryOptions
    {
        AppIntegrationId = gitHubApplicationId,
        ExpirationSeconds = 600
    });
string jwtToken = generator.CreateEncodedJwtToken();
GitHubClient gitHubAppClient = new(new ProductHeaderValue("MyGitHubManagementApp"))
{
    Credentials = new(jwtToken, AuthenticationType.Bearer)
};

// Get a list of installations for the authenticated GitHubApp.
IReadOnlyList<Installation> installations = await gitHubAppClient.GitHubApps.GetAllInstallationsForCurrent();

if (!installations.Any())
{
    throw new Exception("No GitHubApp installations found");
}

// Then create an installation client.
AccessToken installationToken = await gitHubAppClient.GitHubApps.CreateInstallationToken(installations.First().Id);
GitHubClient installationClient = new(new ProductHeaderValue("MyGitHubManagementApp"))
{
    Credentials = new(installationToken.Token)
};

// Configure DI, GitHubWebhooks, and FunctionsWebApplication.
new HostBuilder()
    .ConfigureServices(collection =>
    {
        collection.AddSingleton<WebhookEventProcessor, GitHubWebhookEventProcessor>();
        collection.AddSingleton<GitHubClient>(installationClient);
    })
    .ConfigureGitHubWebhooks()
    .ConfigureFunctionsWebApplication()
    .Build()
    .Run();