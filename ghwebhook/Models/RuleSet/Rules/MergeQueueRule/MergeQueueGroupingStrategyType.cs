namespace ghwebhook.Models;

/// <summary>
/// Specifies the grouping strategy for the merge queue.
/// </summary>
public enum MergeQueueGroupingStrategyType
{
    /// <summary>
    /// All entries must be green.
    /// </summary>
    ALLGREEN,

    /// <summary>
    /// Only the head entry must be green.
    /// </summary>
    HEADGREEN
}
