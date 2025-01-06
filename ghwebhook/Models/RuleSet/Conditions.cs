namespace ghwebhook.Models;

/// <summary>
/// Represents the conditions for the rule set.
/// </summary>
public class Conditions
{
    /// <summary>
    /// Gets or sets the reference name conditions.
    /// </summary>
    [JsonPropertyName("ref_name")]
    public RefName RefName { get; set; } = new();
}
