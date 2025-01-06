namespace ghwebhook.Models;

/// <summary>
/// Represents the parameters for file path restriction rules.
/// </summary>
public class FilePathRestrictionParameters
{
    /// <summary>
    /// Gets or sets the list of restricted file paths.
    /// </summary>
    [JsonPropertyName("restricted_file_paths")]
    public List<string> RestrictedFilePaths { get; set; } = new();
}