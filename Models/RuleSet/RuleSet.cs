namespace ghwebhook.Models;

/// <summary>
/// Represents a set of rules for a GitHub repository.
/// </summary>
public class RuleSet
{
    /// <summary>
    /// Gets or sets the owner of the repository.
    /// </summary>
    [JsonPropertyName("owner")]
    public string Owner { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the repository name.
    /// </summary>
    [JsonPropertyName("repo")]
    public string Repo { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the name of the rule set.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the target type of the rule set.
    /// </summary>
    [JsonPropertyName("target")]
    public TargetType Target { get; set; } = TargetType.branch;

    /// <summary>
    /// Gets or sets the enforcement level of the rule set.
    /// </summary>
    [JsonPropertyName("enforcement")]
    public RuleEnforcement Enforcement { get; set; }

    /// <summary>
    /// Gets or sets the list of actors who can bypass the rules.
    /// </summary>
    [JsonPropertyName("bypass_actors")]
    public List<BypassActor> BypassActorss { get; set; } = new();

    /// <summary>
    /// Gets or sets the conditions for the rule set.
    /// </summary>
    [JsonPropertyName("conditions")]
    public Conditions Conditions { get; set; } = new();

    /// <summary>
    /// Gets or sets the list of rules in the rule set.
    /// </summary>
    [JsonPropertyName("rules")]
    public List<Rule> Rules { get; set; } = new();

    /// <summary>
    /// Gets or sets the headers for the rule set.
    /// </summary>
    [JsonPropertyName("headers")]
    public Headers Headers { get; set; } = new();
}
