namespace ghwebhook.Models;

/// <summary>
/// Rule for managing updates.
/// </summary>
public class UpdateRule : Rule
{
    /// <summary>
    /// Gets the type of the rule.
    /// </summary>
    [JsonPropertyName("type")]
    public override string Type { get; init; } = "update";

    /// <summary>
    /// Gets or sets the parameters for the rule.
    /// </summary>
    [JsonPropertyName("parameters")]
    public UpdateParameters Parameters { get; set; } = new();
}
