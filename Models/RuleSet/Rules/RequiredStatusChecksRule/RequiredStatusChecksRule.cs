namespace ghwebhook.Models;

/// <summary>
/// Rule for managing required status checks.
/// </summary>
public class RequiredStatusChecksRule : Rule
{
    /// <summary>
    /// Gets the type of the rule.
    /// </summary>
    [JsonPropertyName("type")]
    public override string Type { get; init; } = "required_status_checks";

    /// <summary>
    /// Gets or sets the parameters for the rule.
    /// </summary>
    [JsonPropertyName("parameters")]
    public RequiredStatusChecksParameters Parameters { get; set; } = new();
}
