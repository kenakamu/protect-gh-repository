namespace ghwebhook.Models;

/// <summary>
/// Parameters for the required deployments rule.
/// </summary>
public class RequiredDeploymentsParameters
{
    /// <summary>
    /// Gets or sets the list of required deployment environments.
    /// </summary>
    [JsonPropertyName("required_deployment_environments")]
    public List<string> RequiredDeploymentEnvironments { get; set; } = new();
}