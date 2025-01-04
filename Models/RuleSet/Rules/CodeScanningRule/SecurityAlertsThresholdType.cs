namespace ghwebhook.Models;

/// <summary>
/// Represents the threshold levels for security alerts.
/// </summary>
public enum SecurityAlertsThresholdType
{
    /// <summary>
    /// No security alerts.
    /// </summary>
    none,
    /// <summary>
    /// Critical security alerts.
    /// </summary>
    critical,
    /// <summary>
    /// High or higher security alerts.
    /// </summary>
    high_or_higher,
    /// <summary>
    /// Medium or higher security alerts.
    /// </summary>
    medium_or_higher,
    /// <summary>
    /// All security alerts.
    /// </summary>
    all
}
