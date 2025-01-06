namespace ghwebhook.Models;

/// <summary>
/// Parameters for the merge queue rule.
/// </summary>
public class MergeQueueParameters
{
    /// <summary>
    /// Gets or sets a value indicating whether to check response timeout in minutes.
    /// </summary>
    [JsonPropertyName("check_response_timeout_minutes")]
    public bool CheckResponseTimeoutMinutes { get; set; }

    /// <summary>
    /// Gets or sets the grouping strategy for the merge queue.
    /// </summary>
    [JsonPropertyName("grouping_strategy")]
    public MergeQueueGroupingStrategyType GroupingStrategy { get; set; }

    /// <summary>
    /// Gets or sets the maximum number of entries to build.
    /// </summary>
    [JsonPropertyName("max_entries_to_build")]
    public int MaxEntriesToBuild { get; set; }

    /// <summary>
    /// Gets or sets the maximum number of entries to merge.
    /// </summary>
    [JsonPropertyName("max_entries_to_merge")]
    public int MaxEntriesToMerge { get; set; }

    /// <summary>
    /// Gets or sets the merge method for the queue.
    /// </summary>
    [JsonPropertyName("merge_method")]
    public MergeQueueMergeMethodType MergeMethod { get; set; }

    /// <summary>
    /// Gets or sets the minimum number of entries to merge.
    /// </summary>
    [JsonPropertyName("min_entries_to_merge")]
    public int MinEntriesToMerge { get; set; }

    /// <summary>
    /// Gets or sets the wait time in minutes for the minimum number of entries to merge.
    /// </summary>
    [JsonPropertyName("min_entries_to_merge_wait_minutes ")]
    public int MinEntriesToMergeEaitMinutes { get; set; }
}