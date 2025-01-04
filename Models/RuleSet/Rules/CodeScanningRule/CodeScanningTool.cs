namespace ghwebhook.Models;

/// <summary>
/// Represents a code scanning tool with alert thresholds.
/// </summary>
public class CodeScanningTool
{
    /// <summary>
    /// Gets or sets the alerts threshold.
    /// </summary>
    [JsonPropertyName("alerts_threshold")]
    public AlertsThresholdType AlertsThreshold { get; set; }

    /// <summary>
    /// Gets or sets the security alerts threshold.
    /// </summary>
    [JsonPropertyName("security_alerts_threshold")]
    public SecurityAlertsThresholdType SecurityAlertsThreshold { get; set; }

    /// <summary>
    /// Gets or sets the name of the tool.
    /// </summary>
    [JsonPropertyName("tool")]
    public string Tool { get; set; } = string.Empty;
}