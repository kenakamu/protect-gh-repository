namespace ghwebhook.Models;

/// <summary>
/// Rule for matching commit author email patterns.
/// </summary>
public class CommitAuthorEmailPatternRule : Rule
{
    /// <summary>
    /// Gets the type of the rule.
    /// </summary>
    [JsonPropertyName("type")]
    public override string Type { get; init; } = "commit_author_email_pattern";

    /// <summary>
    /// Gets or sets the parameters for the rule.
    /// </summary>
    [JsonPropertyName("parameters")]
    public PatternParameters Parameters { get; set; } = new();
}
