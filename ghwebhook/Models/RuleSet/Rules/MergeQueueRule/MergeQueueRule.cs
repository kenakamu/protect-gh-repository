namespace ghwebhook.Models;

/// <summary>
/// Rule for managing merge queues.
/// </summary>
public class MergeQueueRule : Rule
{
    /// <summary>
    /// Gets the type of the rule.
    /// </summary>
    [JsonPropertyName("type")]
    public override string Type { get; init; } = "merge_queue";

    /// <summary>
    /// Gets or sets the parameters for the rule.
    /// </summary>
    [JsonPropertyName("parameters")]
    public MergeQueueParameters Parameters { get; set; } = new();
}
