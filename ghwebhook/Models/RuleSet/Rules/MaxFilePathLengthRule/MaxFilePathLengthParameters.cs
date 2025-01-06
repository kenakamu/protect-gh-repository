namespace ghwebhook.Models;

/// <summary>
/// Represents the parameters for maximum file path length rules.
/// </summary>
public class MaxFilePathLengthParameters
{
    /// <summary>
    /// Gets or sets the maximum file path length.
    /// </summary>
    [JsonPropertyName("max_file_path_length")]
    public int MaxFilePathLength { get; set; }
}