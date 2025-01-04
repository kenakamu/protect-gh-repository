namespace ghwebhook.Models;

/// <summary>
/// Rule for managing pull requests.
/// </summary>
public class PullRequestRule : Rule
{
    /// <summary>
    /// Gets the type of the rule.
    /// </summary>
    [JsonPropertyName("type")]
    public override string Type { get; init; } = "pull_request";

    /// <summary>
    /// Gets or sets the parameters for the rule.
    /// </summary>
    [JsonPropertyName("parameters")]
    public PullRequestParameters Parameters { get; set; } = new();
}
