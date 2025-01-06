namespace ghwebhook.Models;

/// <summary>
/// Represents the reference names for the rule set.
/// </summary>
public class RefName
{
    /// <summary>
    /// Gets or sets the list of excluded reference names.
    /// </summary>
    [JsonPropertyName("exclude")]
    public List<object> Exclude { get; set; } = new();

    /// <summary>
    /// Gets or sets the list of included reference names.
    /// </summary>
    [JsonPropertyName("include")]
    public List<string> Include { get; set; } = new();
}
