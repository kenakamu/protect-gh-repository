namespace ghwebhook.Models;

/// <summary>
/// Rule for matching tag name patterns.
/// </summary>
public class TagNamePatternRule : Rule
{
    /// <summary>
    /// Gets the type of the rule.
    /// </summary>
    [JsonPropertyName("type")]
    public override string Type { get; init; } = "tag_name_pattern";

    /// <summary>
    /// Gets or sets the parameters for the rule.
    /// </summary>
    [JsonPropertyName("parameters")]
    public PatternParameters Parameters { get; set; } = new();
}
