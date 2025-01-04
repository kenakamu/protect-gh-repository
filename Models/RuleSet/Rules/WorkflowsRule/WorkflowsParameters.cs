namespace ghwebhook.Models;

/// <summary>
/// Parameters for the workflows rule.
/// </summary>
public class WorkflowsParameters
{
    /// <summary>
    /// Gets or sets a value indicating whether to enforce workflows on create.
    /// </summary>
    [JsonPropertyName("do_not_enforce_on_create")]
    public bool DoNotEnforceOnCreate { get; set; }

    /// <summary>
    /// Gets or sets the list of workflows.
    /// </summary>
    [JsonPropertyName("workflows")]
    public List<RuleSetWorkflow> Workflows { get; set; } = new();
}