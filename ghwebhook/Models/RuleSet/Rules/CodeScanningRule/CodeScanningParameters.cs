namespace ghwebhook.Models;

/// <summary>
/// Represents the parameters for code scanning rules.
/// </summary>
public class CodeScanningParameters
{
    /// <summary>
    /// Gets or sets the list of code scanning tools.
    /// </summary>
    [JsonPropertyName("code_scanning_tools")]
    public List<CodeScanningTool> CodeScanningTools { get; set; } = new();
}