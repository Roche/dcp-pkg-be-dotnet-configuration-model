namespace OpenDCP.Framework.Configuration.Model.Entities.ConnectionBridge
{
    /// <summary>
    /// Represents a specific key-value pair used within an event frame mapping configuration.
    /// </summary>
    /// <remarks>
    /// This class defines the relationship between a specific attribute name and its corresponding 
    /// value or identifier used during the data transformation process.
    /// </remarks>
    public class EventFrameMappingKey
    {
        /// <summary>
        /// Gets or sets the name of the mapping key or attribute.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the value associated with the specific mapping key.
        /// </summary>
        public string Value { get; set; }
    }
}
