using System;
using System.Text.Json.Nodes;

namespace OpenDCP.Framework.Configuration.Model.Entities.Site
{
    [Obsolete]
    public class LegacySystemTextSiteConfigurationDTO
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public JsonObject RConnection { get; set; }

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
