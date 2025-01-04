namespace ghwebhook.Models;

/// <summary>
/// Specifies the bypass mode for the rule set.
/// </summary>
public enum BypassMode
{
    /// <summary>
    /// Always bypass the rules.
    /// </summary>
    always,

    /// <summary>
    /// Bypass the rules only for pull requests.
    /// </summary>
    pull_request,
}
