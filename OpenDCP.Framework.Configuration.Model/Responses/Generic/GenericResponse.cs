using OpenDCP.Framework.Configuration.Model.Errors;
using OpenDCP.Framework.Configuration.Model.Warnings;
using System.Collections.Generic;

namespace OpenDCP.Framework.Configuration.Model.Responses.Generic
{
    /// <summary>
    /// A generic container for data source responses that includes a strongly-typed data payload.
    /// </summary>
    public class GenericResponse<TError, TWarning>
        where TError : GenericError
        where TWarning : GenericWarning
    {
        /// <summary>
        /// Gets or sets a list of critical errors that occurred during the data source request.
        /// </summary>
        public virtual List<TError> Errors { get; set; } = new List<TError>();

        /// <summary>
        /// Gets or sets a list of non-critical warnings encountered during the data source request.
        /// </summary>
        public virtual List<TWarning> Warnings { get; set; } = new List<TWarning>();
    }
}
