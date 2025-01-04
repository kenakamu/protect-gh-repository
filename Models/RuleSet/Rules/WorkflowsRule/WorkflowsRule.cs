namespace ghwebhook.Models;

/// <summary>
/// Rule for managing workflows.
/// </summary>
public class WorkflowsRule : Rule
{
    /// <summary>
    /// Gets the type of the rule.
    /// </summary>
    [JsonPropertyName("type")]
    public override string Type { get; init; } = "workflows";

    /// <summary>
    /// Gets or sets the parameters for the rule.
    /// </summary>
    [JsonPropertyName("parameters")]
    public WorkflowsParameters Parameters { get; set; } = new();
}
