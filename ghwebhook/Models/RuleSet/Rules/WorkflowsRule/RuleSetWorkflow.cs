namespace ghwebhook.Models;

/// <summary>
/// Represents a workflow in the rule set.
/// </summary>
public class RuleSetWorkflow
{
    /// <summary>
    /// Gets or sets the path of the workflow.
    /// </summary>
    [JsonPropertyName("path")]
    public string Path { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the reference of the workflow.
    /// </summary>
    [JsonPropertyName("ref")]
    public string Ref { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the repository ID of the workflow.
    /// </summary>
    [JsonPropertyName("repository_id")]
    public int RepositoryId { get; set; }

    /// <summary>
    /// Gets or sets the SHA of the workflow.
    /// </summary>
    [JsonPropertyName("sha")]
    public string Sha { get; set; } = string.Empty;
}