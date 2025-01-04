namespace ghwebhook.Models;

/// <summary>
/// Represents a rule that restricts file paths.
/// </summary>
public class FilePathRestrictionRule : Rule
{
    /// <summary>
    /// Gets the type of the rule.
    /// </summary>
    [JsonPropertyName("type")]
    public override string Type { get; init; } = "file_path_restriction";

    /// <summary>
    /// Gets or sets the parameters for the file path restriction rule.
    /// </summary>
    [JsonPropertyName("parameters")]
    public FilePathRestrictionParameters Parameters { get; set; } = new();
}
