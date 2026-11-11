using OpenDCP.Framework.Configuration.Model.Errors;
using OpenDCP.Framework.Configuration.Model.Responses.Generic;
using OpenDCP.Framework.Configuration.Model.Warnings;

namespace OpenDCP.Framework.Configuration.Model.Responses.Service
{
    public class ServiceResponse<T> : GenericResponse<GenericError, GenericWarning>
    {
        /// <summary>
        /// Gets or sets the data returned by the service.
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the data source passed GxP validation.
        /// This validation ensures that the originating system and data acquisition
        /// comply with applicable GxP requirements.
        /// A value of <c>null</c> indicates that the validation was not performed.
        /// </summary>
        public bool? DatasourceValidation { get; set; } = null;

        /// <summary>
        /// Gets or sets a value indicating whether calculations applied to the data
        /// passed GxP validation.
        /// This validation ensures that all processing and calculation steps
        /// comply with applicable GxP requirements.
        /// A value of <c>null</c> indicates that the validation was not performed.
        /// </summary>
        public bool? CalculationValidation { get; set; } = null;

        /// <summary>
        /// Gets or sets a value indicating whether the entity and its state
        /// passed GxP validation.
        /// This validation ensures that the entity definition, lifecycle state,
        /// and associated metadata comply with applicable GxP requirements.
        /// A value of <c>null</c> indicates that the validation was not performed.
        /// </summary>
        public bool? EntityValidation { get; set; } = null;
    }
}
