using OpenDCP.Framework.Configuration.Model.Attributes;
using OpenDCP.Framework.Configuration.Model.Constants.Datasource;

namespace OpenDCP.Framework.Configuration.Model.Errors
{
    /// <summary>
    /// Represents a critical error originating from an underlying data source during a query or retrieval operation.
    /// </summary>
    public sealed class DatasourceError : GenericError
    {
        /// <summary>
        /// Gets or sets the unique identifier of the specific data source, tag, or attribute that failed.
        /// </summary>
        [ConnectionManagerAttribute(RequestPipelineAction.Transform)]
        public override string Identifier { get; set; }
    }
}
