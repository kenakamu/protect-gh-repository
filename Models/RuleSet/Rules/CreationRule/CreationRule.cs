namespace ghwebhook.Models;

/// <summary>
/// Represents a rule for creations.
/// </summary>
public class CreationRule : Rule
{
    /// <summary>
    /// Gets the type of the rule.
    /// </summary>
    [JsonPropertyName("type")]
    public override string Type { get; init; } = "creation";
}
