using Newtonsoft.Json;
using OpenDCP.Framework.Configuration.Model.Entities.CalculationNode;
using System;
using System.Text.Json.Nodes;

namespace OpenDCP.Framework.Configuration.Model.Entities.Site
{
    [Obsolete]
    public class LegacySiteConfigurationDTO_v2
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [JsonProperty("RConnection")]
        public CalculationNodeConnectionDTO CalculationNodeConfiguration { get; set; }
        public byte ConnectionType { get; set; }
        public JsonObject ConnectionString { get; set; }
        public bool IsModuleValidated { get; set; }
        public bool IsDataSourceValidated { get; set; }
        public int DataSourceId { get; set; }
        public string ShortName { get; set; }
        public string TimeZone { get; set; }
        public bool IsEnable { get; set; }
        public bool IsModuleEnabled { get; set; }
    }
}
