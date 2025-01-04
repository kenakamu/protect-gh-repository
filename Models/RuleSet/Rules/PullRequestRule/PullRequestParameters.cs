namespace ghwebhook.Models;

/// <summary>
/// Parameters for the pull request rule.
/// </summary>
public class PullRequestParameters
{
    /// <summary>
    /// Gets or sets the required number of approving reviews.
    /// </summary>
    [JsonPropertyName("required_approving_review_count")]
    public int RequiredApprovingReviewCount { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to dismiss stale reviews on push.
    /// </summary>
    [JsonPropertyName("dismiss_stale_reviews_on_push")]
    public bool DismissStaleReviewsOnPush { get; set; } = false;

    /// <summary>
    /// Gets or sets a value indicating whether code owner review is required.
    /// </summary>
    [JsonPropertyName("require_code_owner_review")]
    public bool RequireCodeOwnerReview { get; set; } = false;

    /// <summary>
    /// Gets or sets a value indicating whether approval is required for the last push.
    /// </summary>
    [JsonPropertyName("require_last_push_approval")]
    public bool RequireLastPushApproval { get; set; } = false;

    /// <summary>
    /// Gets or sets a value indicating whether review thread resolution is required.
    /// </summary>
    [JsonPropertyName("required_review_thread_resolution")]
    public bool RequiredReviewThreadResolution { get; set; } = false;

    /// <summary>
    /// Gets or sets a value indicating whether automatic Copilot code review is enabled.
    /// </summary>
    [JsonPropertyName("automatic_copilot_code_review_enabled")]
    public bool AutomaticCopilotCodeReview_enabled { get; set; } = false;

    /// <summary>
    /// Gets or sets the allowed merge methods.
    /// </summary>
    [JsonPropertyName("allowed_merge_methods")]
    public List<string> AllowedMergeMethods { get; set; } = new();
}