namespace ghwebhook.Models;

/// <summary>
/// Represents a rule that restricts file extensions.
/// </summary>
public class FileExtensionRestrictionRule : Rule
{
    /// <summary>
    /// Gets the type of the rule.
    /// </summary>
    [JsonPropertyName("type")]
    public override string Type { get; init; } = "file_extension_restriction";

    /// <summary>
    /// Gets or sets the parameters for the file extension restriction rule.
    /// </summary>
    [JsonPropertyName("parameters")]
    public FileExtensionRestrictionParameters Parameters { get; set; } = new();
}
