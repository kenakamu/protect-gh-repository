namespace ghwebhook.Models;

/// <summary>
/// Specifies the default QuerySuite for code scanning
/// </summary>
public enum DefaultSetupQuerySuiteType
{
    /// <summary>
    /// default
    /// </summary>
    [JsonPropertyName("default")]
    @default,

    /// <summary>
    /// extended
    /// </summary>
    extended,
}
