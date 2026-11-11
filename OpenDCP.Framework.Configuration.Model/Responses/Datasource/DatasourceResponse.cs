using OpenDCP.Framework.Configuration.Model.Attributes;
using OpenDCP.Framework.Configuration.Model.Constants.Datasource;
using OpenDCP.Framework.Configuration.Model.Errors;
using OpenDCP.Framework.Configuration.Model.Responses.Generic;
using OpenDCP.Framework.Configuration.Model.Warnings;
using System.Collections.Generic;

namespace OpenDCP.Framework.Configuration.Model.Responses.Datasource
{
    /// <summary>
    /// Represents the base response structure for all data source operations, containing shared diagnostic information.
    /// </summary>
    public class DatasourceResponse : GenericResponse<DatasourceError, DatasourceWarning>
    {
        /// <summary>
        /// Gets or sets a list of critical errors with custom pipeline processing rules.
        /// </summary>
        [ConnectionManagerAttribute(RequestPipelineAction.Reduce)]
        public override List<DatasourceError> Errors { get; set; } = new List<DatasourceError>();

        /// <summary>
        /// Gets or sets a list of non-critical warnings with custom pipeline processing rules.
        /// </summary>
        [ConnectionManagerAttribute(RequestPipelineAction.Reduce)]
        public override List<DatasourceWarning> Warnings { get; set; } = new List<DatasourceWarning>();
    }
}
