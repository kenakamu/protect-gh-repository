namespace ghwebhook.Models;

/// <summary>
/// Specifies the type of actor that can bypass the rules.
/// </summary>
public enum BypassActorType
{
    /// <summary>
    /// Integration actor.
    /// </summary>
    Integration,

    /// <summary>
    /// Organization admin actor.
    /// </summary>
    OrganizationAdmin,

    /// <summary>
    /// Repository role actor.
    /// </summary>
    RepositoryRole,

    /// <summary>
    /// Team actor.
    /// </summary>
    Team,

    /// <summary>
    /// Deploy key actor.
    /// </summary>
    DeployKey
}
