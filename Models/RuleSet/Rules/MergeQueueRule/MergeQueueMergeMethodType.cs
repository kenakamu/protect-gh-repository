namespace ghwebhook.Models;

/// <summary>
/// Specifies the merge method for the merge queue.
/// </summary>
public enum MergeQueueMergeMethodType
{
    /// <summary>
    /// Merge commits.
    /// </summary>
    MERGE,

    /// <summary>
    /// Squash commits.
    /// </summary>
    SQUASH,

    /// <summary>
    /// Rebase commits.
    /// </summary>
    REBASE
}
