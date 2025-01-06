namespace ghwebhook.Models;

/// <summary>
/// Represents a rule for code scanning.
/// </summary>
public class CodeScanningRule : Rule
{
    /// <summary>
    /// Gets the type of the rule.
    /// </summary>
    [JsonPropertyName("type")]
    public override string Type { get; init; } = "code_scanning";

    /// <summary>
    /// Gets or sets the parameters for the code scanning rule.
    /// </summary>
    [JsonPropertyName("parameters")]
    public CodeScanningParameters Parameters { get; set; } = new();
}