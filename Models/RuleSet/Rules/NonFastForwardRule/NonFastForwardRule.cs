namespace ghwebhook.Models;

/// <summary>
/// Rule for non-fast-forward merges.
/// </summary>
public class NonFastForwardRule : Rule
{
    /// <summary>
    /// Gets the type of the rule.
    /// </summary>
    [JsonPropertyName("type")]
    public override string Type { get; init; } = "non_fast_forward";
}
