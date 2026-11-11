using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenDCP.Framework.Configuration.Model.Entities.ConnectionBridge
{
    /// <summary>
    /// Represents a compiled mapping expression used to evaluate and filter data consistency between primary and secondary data sources.
    /// </summary>
    /// <remarks>
    /// This class transforms a flat DTO definition into a structured set of mapping keys that can be used to validate 
    /// or filter event frame data during the synchronization process.
    /// </remarks>
    public class MappingExpression
    {
        /// <summary>
        /// Gets the collection of mapping keys associated with the primary data source.
        /// </summary>
        public List<MappingKey> PrimaryMappingKeys { get; private set; }

        /// <summary>
        /// Gets the collection of mapping keys associated with the secondary data source.
        /// </summary>
        public List<MappingKey> SecondaryMappingKeys { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MappingExpression"/> class by parsing a bridge definition.
        /// </summary>
        /// <param name="definition">A list of <see cref="ConnectionBridgeKeyMappingDTO"/> defining the keys to be mapped.</param>
        public MappingExpression(List<ConnectionBridgeKeyMappingDTO> definition)
        {
            PrimaryMappingKeys = new List<MappingKey>();
            SecondaryMappingKeys = new List<MappingKey>();

            foreach (var mapKey in definition)
            {
                PrimaryMappingKeys.Add(new MappingKey(mapKey.PrimaryDataSourceKey));
                SecondaryMappingKeys.Add(new MappingKey(mapKey.SecondaryDataSourceKey));
            }
        }

        /// <summary>
        /// Determines whether the provided event frame values satisfy all filtering criteria defined in the secondary mapping keys.
        /// </summary>
        /// <param name="values">A list of <see cref="EventFrameMappingKey"/> representing the actual data values to evaluate.</param>
        /// <returns><c>true</c> if all secondary mapping keys successfully filter/match the provided values; otherwise, <c>false</c>.</returns>
        public bool Filter(List<EventFrameMappingKey> values)
        {
            return SecondaryMappingKeys.All(x => x.Filter(values));
        }
    }
}
