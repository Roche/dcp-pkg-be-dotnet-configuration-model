using System.Collections.Generic;

namespace OpenDCP.Framework.Configuration.Model.Entities.ConnectionBridge
{
    /// <summary>
    /// Represents the configuration for mapping event frame data between systems, 
    /// utilizing a primary global identifier and a collection of specific mapping keys.
    /// </summary>
    public class EventFrameMapping
    {
        /// <summary>
        /// Gets or sets the global identifier key used to uniquely correlate event frames across different data sources.
        /// </summary>
        public string PrimaryGlobalIdentifierKey { get; set; }
        /// <summary>
        /// Gets or sets the list of detailed mapping keys that define specific attribute translations for the event frame.
        /// </summary>
        public List<EventFrameMappingKey> Keys { get; set; }
    }
}
