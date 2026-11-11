using Newtonsoft.Json.Linq;
using System;

namespace OpenDCP.Framework.Configuration.Model.Entities.Site
{
    [Obsolete]
    public class LegacySiteConfigurationDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public JObject RConnection { get; set; }
        public byte ConnectionType { get; set; }
        public JObject ConnectionString { get; set; }
        public bool IsModuleValidated { get; set; }
        public bool IsDataSourceValidated { get; set; }
        public int DataSourceId { get; set; }
        public string ShortName { get; set; }
        public string TimeZone { get; set; }
        public bool IsEnable { get; set; }
        public bool IsModuleEnabled { get; set; }
    }
}
