namespace ghwebhook.Models;

/// <summary>
/// Specifies the default setupstate for code scanning
/// </summary>
public enum DefaultSetupStateType
{
    /// <summary>
    /// Configured
    /// </summary>
    [JsonPropertyName("configured")]
    Configured,

    /// <summary>
    /// Not Configured
    /// </summary>
    [JsonPropertyName("not-configured")]
    NotConfigured,
}
