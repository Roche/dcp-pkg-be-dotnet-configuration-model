using System;

namespace OpenDCP.Framework.Configuration.Model.Entities.Datasource
{
    [Obsolete]
    public class DataTypeDTO
    {
        public int DataTypeId { get; set; }
        public byte DataType { get; set; }
        public int DataSourceId { get; set; }
    }
}
