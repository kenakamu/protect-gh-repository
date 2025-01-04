namespace ghwebhook.Models;

/// <summary>
/// Represents a required status check.
/// </summary>
public class RequireStatusCheck
{
    /// <summary>
    /// Gets or sets the context of the status check.
    /// </summary>
    [JsonPropertyName("context")]
    public string Context { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the integration ID of the status check.
    /// </summary>
    [JsonPropertyName("integration_id")]
    public int? IntegrationId { get; set; }
}