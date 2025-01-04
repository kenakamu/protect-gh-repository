namespace ghwebhook.Models;

/// <summary>
/// Represents the parameters for maximum file size rules.
/// </summary>
public class MaxFileSizeParameters
{
    /// <summary>
    /// Gets or sets the maximum file size.
    /// </summary>
    [JsonPropertyName("max_file_size")]
    public int MaxFileSize { get; set; }
}