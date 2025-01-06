namespace ghwebhook.Models;

/// <summary>
/// Parameters for the update rule.
/// </summary>
public class UpdateParameters
{
    /// <summary>
    /// Gets or sets a value indicating whether updates allow fetch and merge.
    /// </summary>
    [JsonPropertyName("update_allows_fetch_and_merge")]
    public bool UpdateAllowsFetchAndMerge { get; set; }
}