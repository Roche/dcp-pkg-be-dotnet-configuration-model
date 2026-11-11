namespace OpenDCP.Framework.Configuration.Model.Constants
{
    /// <summary>
    /// Defines error codes for high-level, non-domain-specific failures within the system.
    /// </summary>
    /// <remarks>
    /// General error codes are reserved for the range 0–999. These codes typically represent 
    /// infrastructure, communication, or data processing failures that can occur across any module.
    /// </remarks>
    public enum GeneralErrorCode : byte
    {
        /// <summary>
        /// Indicates that a network or service request did not return a successful HTTP status code (2xx).
        /// </summary>
        NoSuccessStatusCode = 0,

        /// <summary>
        /// Indicates a failure during the serialization or deserialization of data (e.g., malformed JSON or XML).
        /// </summary>
        ParsingError = 1,
    }
}
