using OpenDCP.Framework.Configuration.Model.Attributes;

namespace OpenDCP.Framework.Configuration.Model.Warnings
{
    /// <summary>
    /// Represents a non-critical issue or diagnostic message originating from a data source during a query or calculation.
    /// </summary>
    public class DatasourceWarning : GenericWarning
    {
        /// <summary>
        /// Gets or sets the unique identifier of the specific data source, tag, or attribute that failed.
        /// </summary>
        [ConnectionManagerAttribute(Constants.Datasource.RequestPipelineAction.Transform)]
        public override string Identifier { get; set; }
    }
}
