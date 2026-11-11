using System;
using System.Collections.Generic;

namespace OpenDCP.Framework.Configuration.Model.Requests
{
    [Obsolete]
    public class DataSourcesDetailsRequest
    {
        public List<int> DatasourceIds { get; set; }
        public int SiteId { get; set; }
    }
}
