using OpenDCP.Framework.Configuration.Model.Constants.Datasource;

namespace OpenDCP.Framework.Configuration.Model.Entities.ModuleSettings
{
    /// <summary>
    /// Data Transfer Object that defines the configuration and constraints for a specific data type within a module.
    /// </summary>
    public class ModuleDataTypeConfigurationDTO
    {
        /// <summary>
        /// Gets or sets the category of the data type (e.g., Equipment, Experiment, ProcessMonitoring).
        /// </summary>
        public DataType Type { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether a selection for this data type is required.
        /// </summary>
        /// <value><c>true</c> if the field must be populated; otherwise, <c>false</c>.</value>
        public bool Mandatory { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user is permitted to select multiple values for this data type.
        /// </summary>
        /// <value><c>true</c> if multi-selection is enabled; <c>false</c> if only a single selection is allowed.</value>
        public bool AllowMultiselection { get; set; }
    }
}
