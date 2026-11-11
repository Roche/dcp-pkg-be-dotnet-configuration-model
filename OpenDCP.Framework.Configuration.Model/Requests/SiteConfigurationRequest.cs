using System;
using System.Collections.Generic;

namespace OpenDCP.Framework.Configuration.Model.Requests
{
    [Obsolete]
    public class SiteConfigurationRequest
    {
        public string CurrentUser { get; set; }
        public int SiteId { get; set; }
        public string Module { get; set; }
        public List<int> SiteIds { get; set; }
        public byte DataType { get; set; }
    }
}
