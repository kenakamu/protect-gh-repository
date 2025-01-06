namespace ghwebhook.Models;

/// <summary>
/// Represents a rule that restricts the maximum file path length.
/// </summary>
public class MaxFilePathLengthRule : Rule
{
    /// <summary>
    /// Gets the type of the rule.
    /// </summary>
    [JsonPropertyName("type")]
    public override string Type { get; init; } = "max_file_path_length";

    /// <summary>
    /// Gets or sets the parameters for the maximum file path length rule.
    /// </summary>
    [JsonPropertyName("parameters")]
    public MaxFilePathLengthParameters Parameters { get; set; } = new();
}
