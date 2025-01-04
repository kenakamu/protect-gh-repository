namespace ghwebhook.Models;

/// <summary>
/// Represents a rule for deletions.
/// </summary>
public class DeletionRule : Rule
{
    /// <summary>
    /// Gets the type of the rule.
    /// </summary>
    [JsonPropertyName("type")]
    public override string Type { get; init; } = "deletion";
}
