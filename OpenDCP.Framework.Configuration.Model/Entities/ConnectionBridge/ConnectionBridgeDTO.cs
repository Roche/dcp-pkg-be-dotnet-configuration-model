using System;
using System.Collections.Generic;

namespace OpenDCP.Framework.Configuration.Model.Entities.ConnectionBridge
{
    /// <summary>
    /// Data Transfer Object representing a connection bridge that defines the mapping and integration between two distinct data sources at a specific site.
    /// </summary>
    [Obsolete]
    public class ConnectionBridgeDTO
    {
        /// <summary>
        /// Gets or sets the unique identifier for the connection bridge.
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Gets or sets the descriptive name of the connection bridge.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the data type category for the primary connection.
        /// </summary>
        public byte PrimaryConnectionDataType { get; set; }
        /// <summary>
        /// Gets or sets the identifier for the primary data source.
        /// </summary>
        public int PrimaryConnectionDataSourcesId { get; set; }
        /// <summary>
        /// Gets or sets the data type category for the secondary connection.
        /// </summary>
        public byte SecondaryConnectionDataType { get; set; }
        /// <summary>
        /// Gets or sets the identifier for the secondary data source.
        /// </summary>
        public int SecondaryConnectionDataSourcesId { get; set; }
        /// <summary>
        /// Gets or sets the identifier for the site associated with this bridge.
        /// </summary>
        public int SiteId { get; set; }
        /// <summary>
        /// Gets or sets the list of key mappings that define how data fields correlate between the primary and secondary sources.
        /// </summary>
        public List<ConnectionBridgeKeyMappingDTO> KeyMapping { get; set; }
        /// <summary>
        /// Gets or sets the reason or business justification for the bridge configuration.
        /// </summary>
        public string Reason { get; set; }
    }

}
