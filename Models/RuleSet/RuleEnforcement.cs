namespace ghwebhook.Models;

/// <summary>
/// Specifies the enforcement level of the rule set.
/// </summary>
public enum RuleEnforcement
{
    /// <summary>
    /// The rule set is disabled.
    /// </summary>
    disabled,

    /// <summary>
    /// The rule set is active.
    /// </summary>
    active,

    /// <summary>
    /// The rule set is in evaluation mode.
    /// </summary>
    evaluate
}
