namespace ghwebhook.Models;

/// <summary>
/// Rule for requiring deployments.
/// </summary>
public class RequiredDeploymentsRule : Rule
{
    /// <summary>
    /// Gets the type of the rule.
    /// </summary>
    [JsonPropertyName("type")]
    public override string Type { get; init; } = "required_deployments";

    /// <summary>
    /// Gets or sets the parameters for the rule.
    /// </summary>
    [JsonPropertyName("parameters")]
    public RequiredDeploymentsParameters Parameters { get; set; } = new();
}
