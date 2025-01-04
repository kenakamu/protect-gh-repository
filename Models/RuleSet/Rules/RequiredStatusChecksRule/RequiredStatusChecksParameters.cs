namespace ghwebhook.Models;

/// <summary>
/// Parameters for the required status checks rule.
/// </summary>
public class RequiredStatusChecksParameters
{
    /// <summary>
    /// Gets or sets a value indicating whether to enforce status checks on create.
    /// </summary>
    [JsonPropertyName("do_not_enforce_on_create")]
    public bool DoNotEnforceOnCreate { get; set; }

    /// <summary>
    /// Gets or sets the list of required status checks.
    /// </summary>
    [JsonPropertyName("required_status_checks")]
    public List<RequireStatusCheck> RequiredStatusChecks { get; set; } = new();

    /// <summary>
    /// Gets or sets a value indicating whether to enforce a strict status checks policy.
    /// </summary>
    [JsonPropertyName("strict_required_status_checks_policy")]
    public bool StrictRequiredStatusChecksPolicy { get; set; }
}