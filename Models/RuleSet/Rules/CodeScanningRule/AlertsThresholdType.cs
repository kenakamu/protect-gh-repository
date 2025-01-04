namespace ghwebhook.Models;

/// <summary>
/// Represents the threshold levels for alerts.
/// </summary>
public enum AlertsThresholdType
{
    /// <summary>
    /// No alerts.
    /// </summary>
    none,
    /// <summary>
    /// Error alerts.
    /// </summary>
    errors,
    /// <summary>
    /// Error and warning alerts.
    /// </summary>
    errors_and_warnings,
    /// <summary>
    /// All alerts.
    /// </summary>
    all
}
