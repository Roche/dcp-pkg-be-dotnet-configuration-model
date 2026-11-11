namespace OpenDCP.Framework.Configuration.Model.Entities.ConnectionBridge
{
    /// <summary>
    /// Data Transfer Object representing the specific key mapping between two data sources within a connection bridge.
    /// </summary>
    public class ConnectionBridgeKeyMappingDTO
    {
        /// <summary>
        /// Gets or sets the field key or attribute name from the primary data source.
        /// </summary>
        public string PrimaryDataSourceKey { get; set; }
        /// <summary>
        /// Gets or sets the corresponding field key or attribute name in the secondary data source that maps to the primary key.
        /// </summary>
        public string SecondaryDataSourceKey { get; set; }
    }
}
