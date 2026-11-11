using OpenDCP.Framework.Configuration.Model.Constants;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using OpenDCP.Framework.Configuration.Model.Constants.Datasource;

namespace OpenDCP.Framework.Configuration.Model.Entities.Datasource
{
    /// <summary>
    /// Represents the configuration of a datasource, including connection details, data types, and validation status.
    /// </summary>
    public class DatasourceConfigurationDTO
    {
        /// <summary>
        /// Gets or sets the unique identifier of the datasource configuration.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the datasource.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the site associated with this datasource.
        /// </summary>
        public int SiteId { get; set; }

        /// <summary>
        /// Gets or sets the type of connection used by the datasource.
        /// </summary>
        public string ConnectionType { get; set; }

        /// <summary>
        /// Gets or sets the collection of data types that this datasource supports.
        /// </summary>
        public List<DataType> DataTypes { get; set; } = new List<DataType>();

        /// <summary>
        /// Gets or sets the connection string details for the datasource in JSON format.
        /// </summary>
        public JsonObject ConnectionString { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the datasource configuration has been validated.
        /// </summary>
        public bool IsValidated { get; set; }
    }
}
