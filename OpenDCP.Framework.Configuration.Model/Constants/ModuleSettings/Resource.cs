namespace OpenDCP.Framework.Configuration.Model.Constants.ModuleSettings
{
    /// <summary>
    /// Specifies the type of system resource or functional area that a module setting is associated with.
    /// </summary>
    public enum ModuleSettingResource : byte
    {
        /// <summary>
        /// Settings related to event-driven notifications and messaging subscriptions.
        /// </summary>
        EventSubscription = 1,
        /// <summary>
        /// Settings related to the tracking of system changes and user activity logs for compliance.
        /// </summary>
        AuditTrail = 2,
        /// <summary>
        /// Settings related to administrative operations and restricted system-level actions.
        /// </summary>
        AdminAction = 3,
    }
}
