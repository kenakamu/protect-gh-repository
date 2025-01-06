namespace ghwebhook.Models;

/// <summary>
/// Parameters for pattern matching rules.
/// </summary>
public class PatternParameters
{
    /// <summary>
    /// Gets or sets the name of the pattern.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets a value indicating whether to negate the pattern.
    /// </summary>
    [JsonPropertyName("negate")]
    public bool Negate { get; set; }

    /// <summary>
    /// Gets or sets the operator for the pattern.
    /// </summary>
    [JsonPropertyName("operator")]
    public PatternOperatorType Operator { get; set; }

    /// <summary>
    /// Gets or sets the pattern value.
    /// </summary>
    [JsonPropertyName("pattern")]
    public string Pattern { get; set; } = string.Empty;
}