namespace ghwebhook.Models;

/// <summary>
/// Rule for requiring signatures.
/// </summary>
public class RequiredSignaturesRule : Rule
{
    /// <summary>
    /// Gets the type of the rule.
    /// </summary>
    [JsonPropertyName("type")]
    public override string Type { get; init; } = "required_signatures";
}
