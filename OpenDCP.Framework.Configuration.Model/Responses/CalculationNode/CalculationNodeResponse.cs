using OpenDCP.Framework.Configuration.Model.Errors;
using OpenDCP.Framework.Configuration.Model.Responses.Generic;
using OpenDCP.Framework.Configuration.Model.Warnings;
using System.Linq;

namespace OpenDCP.Framework.Configuration.Model.Responses.CalculationNode
{
    /// <summary>
    /// Represents the comprehensive result of a calculation process, aggregating errors and warnings 
    /// from various stages including node validation, mathematical computation, and data retrieval.
    /// </summary>
    public class CalculationNodeResponse : GenericResponse<GenericError, GenericWarning>
    {
        /// <summary>
        /// Gets or sets additional diagnostic or debugging information related to the calculation execution.
        /// </summary>
        /// <value>
        /// A <see cref="string"/> containing debug details. Defaults to <see cref="string.Empty"/>.
        /// </value>
        public string DebugInfo { get; set; } = string.Empty;

        /// <summary>
        /// Aggregates and formats all operational errors into a single, dot-delimited string.
        /// </summary>
        /// <returns>
        /// A dot-separated <see cref="string"/> of error messages. If an error is of type <see cref="NodeError"/>, 
        /// it is generalized to "Calculation node not responding".
        /// </returns>
        public string ToErrorString()
        {
            return string.Join(".",
                Errors?.Select(e => e.GetType() == typeof(NodeError) ?
                    "Calculation node not responding" :
                    e.Error)
            );
        }
    }
}