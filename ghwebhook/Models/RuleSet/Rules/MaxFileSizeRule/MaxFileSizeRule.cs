namespace ghwebhook.Models;

/// <summary>
/// Represents a rule that restricts the maximum file size.
/// </summary>
public class MaxFileSizeRule : Rule
{
    /// <summary>
    /// Gets the type of the rule.
    /// </summary>
    [JsonPropertyName("type")]
    public override string Type { get; init; } = "max_file_size";

    /// <summary>
    /// Gets or sets the parameters for the maximum file size rule.
    /// </summary>
    [JsonPropertyName("parameters")]
    public MaxFileSizeParameters Parameters { get; set; } = new();
}
