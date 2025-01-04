namespace ghwebhook.Models;

/// <summary>
/// Specifies the type of pattern operator.
/// </summary>
public enum PatternOperatorType
{
    /// <summary>
    /// The pattern starts with the specified value.
    /// </summary>
    starts_with,

    /// <summary>
    /// The pattern ends with the specified value.
    /// </summary>
    ends_with,

    /// <summary>
    /// The pattern contains the specified value.
    /// </summary>
    contains,

    /// <summary>
    /// The pattern matches the specified regular expression.
    /// </summary>
    reex
}
