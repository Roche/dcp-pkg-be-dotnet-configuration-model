namespace OpenDCP.Framework.Configuration.Model.Warnings
{
    /// <summary>
    /// Represents a non-critical issue or diagnostic message originating from a data source during a query or calculation.
    /// </summary>
    public class GenericWarning
    {
        /// <summary>
        /// Gets or sets the numeric code associated with the specific warning type.
        /// </summary>
        public byte WarningCode { get; set; }
        /// <summary>
        /// Gets or sets the descriptive message explaining the nature of the warning.
        /// </summary>
        public string Warning { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the unique identifier of the data point, attribute, or source entity that triggered the warning.
        /// </summary>
        public virtual string Identifier { get; set; }
    }
}
