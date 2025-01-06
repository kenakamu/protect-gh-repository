namespace ghwebhook.Models;

/// <summary>
/// Represents an actor that can bypass the rules.
/// </summary>
public class BypassActor
{
    /// <summary>
    /// Gets or sets the ID of the actor.
    /// </summary>
    [JsonPropertyName("actor_id")]
    public int? ActorId { get; set; }

    /// <summary>
    /// Gets or sets the type of the actor.
    /// </summary>
    [JsonPropertyName("actor_type")]
    public BypassActorType ActorType { get; set; }

    /// <summary>
    /// Gets or sets the bypass mode for the actor.
    /// </summary>
    [JsonPropertyName("bypass_mode")]
    public BypassMode BypassMode { get; set; } = BypassMode.always;
}
