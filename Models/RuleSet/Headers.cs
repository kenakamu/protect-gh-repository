namespace ghwebhook.Models;

/// <summary>
/// Represents the headers for the rule set.
/// </summary>
public class Headers
{
    /// <summary>
    /// Gets or sets the GitHub API version header.
    /// </summary>
    [JsonPropertyName("X-GitHub-Api-Version")]
    public string XGitHubApiVersion { get; set; } = "2022-11-28";
}
