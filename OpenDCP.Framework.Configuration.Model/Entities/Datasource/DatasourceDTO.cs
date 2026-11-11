using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace OpenDCP.Framework.Configuration.Model.Entities.Datasource
{
    [Obsolete]
    public class DatasourceDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public byte Type { get; set; }
        public JObject ConnectionString { get; set; }
        public int SiteID { get; set; }
        public bool IsValidated { get; set; }
        public List<byte> SupportedDataTypes { get; set; }

    }
}
