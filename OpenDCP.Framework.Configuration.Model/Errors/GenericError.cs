namespace OpenDCP.Framework.Configuration.Model.Errors
{
    /// <summary>
    /// Represents a critical error
    /// </summary>
    public class GenericError
    {
        /// <summary>
        /// Gets or sets the numeric code associated with the specific  error type.
        /// </summary>
        public int ErrorCode { get; set; }
        /// <summary>
        /// Gets or sets the descriptive error message.
        /// </summary>
        public string Error { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the unique identifier of the specific data source, tag, or attribute that failed.
        /// </summary>
        public virtual string Identifier { get; set; }
    }
}
