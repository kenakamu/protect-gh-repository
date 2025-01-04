namespace ghwebhook.Models;

/// <summary>
/// Rule for requiring linear history.
/// </summary>
public class RequiredLinearHistoryRule : Rule
{
    /// <summary>
    /// Gets the type of the rule.
    /// </summary>
    [JsonPropertyName("type")]
    public override string Type { get; init; } = "required_linear_history";
}
