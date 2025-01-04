namespace ghwebhook.Models;

/// <summary>
/// Rule for matching branch name patterns.
/// </summary>
public class BranchNamePatternRule : Rule
{
    /// <summary>
    /// Gets the type of the rule.
    /// </summary>
    [JsonPropertyName("type")]
    public override string Type { get; init; } = "branch_name_pattern";

    /// <summary>
    /// Gets or sets the parameters for the rule.
    /// </summary>
    [JsonPropertyName("parameters")]
    public PatternParameters Parameters { get; set; } = new();
}
