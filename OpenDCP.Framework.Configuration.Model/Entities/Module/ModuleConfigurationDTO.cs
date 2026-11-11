using OpenDCP.Framework.Configuration.Model.Constants.CalculationNode;
using System.Text.Json.Nodes;

namespace OpenDCP.Framework.Configuration.Model.Entities.Module
{
    /// <summary>
    /// Represents the configuration details for a module/calculation node
    /// </summary>
    public class ModuleConfigurationDTO
    {
        /// <summary>
        /// Gets or sets the unique identifier of the calculation node/module.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the name of the module.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the identifier of the site to which the module belongs.
        /// </summary>
        public int SiteId { get; set; }
        /// <summary>
        /// Gets or sets the type of calculation node used by the module.
        /// </summary>
        public CalculationNodeType CalculationNodeType { get; set; }
        /// <summary>
        /// Gets or sets the connection string details as a JSON object.
        /// </summary>
        public JsonObject ConnectionString { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether the calculation node can be used for GxP/validated purposes
        /// </summary>
        public bool IsValidated { get; set; } = false;
        /// <summary>
        /// Gets or sets a value indicating whether the module is enabled.
        /// </summary>
        public bool IsEnabled { get; set; } = true;
    }
}
