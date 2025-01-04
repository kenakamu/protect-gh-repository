namespace ghwebhook.Models;

/// <summary>
/// Represents the parameters for file extension restriction rules.
/// </summary>
public class FileExtensionRestrictionParameters
{
    /// <summary>
    /// Gets or sets the list of restricted file extensions.
    /// </summary>
    [JsonPropertyName("restricted_file_extensions")]
    public List<string> RestrictedFileExtensions { get; set; } = new();
}