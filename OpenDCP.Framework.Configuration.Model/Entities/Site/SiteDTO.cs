using OpenDCP.Framework.Configuration.Model.Entities.Datasource;
using OpenDCP.Framework.Configuration.Model.Entities.ModuleSettings;
using System;
using System.Collections.Generic;

namespace OpenDCP.Framework.Configuration.Model.Entities.Site
{
    [Obsolete]
    public class SiteDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string TimeZone { get; set; }
        public bool IsEnable { get; set; }
        public string Reason { get; set; }
        public byte SiteType { get; set; }
        public List<ModuleDTO> Modules { get; set; }
        public List<DatasourceDTO> DataSources { get; set; }
    }
}
