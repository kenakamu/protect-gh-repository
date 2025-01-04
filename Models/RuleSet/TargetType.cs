namespace ghwebhook.Models;

/// <summary>
/// Specifies the target type for the rule set.
/// </summary>
public enum TargetType
{
    /// <summary>
    /// Target is a branch.
    /// </summary>
    branch,

    /// <summary>
    /// Target is a tag.
    /// </summary>
    tag,

    /// <summary>
    /// Target is a push.
    /// </summary>
    push
}
