namespace ghwebhook.Models;

/// <summary>
/// Represents a base rule with a type property.
/// </summary>
public class Rule
{
    /// <summary>
    /// Gets the type of the rule.
    /// </summary>
    [JsonPropertyName("type")]
    public virtual string Type { get; init; } = string.Empty;
}
