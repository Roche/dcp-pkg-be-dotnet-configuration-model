using OpenDCP.Framework.Configuration.Model.Entities.CalculationNode;
using OpenDCP.Framework.Configuration.Model.Entities.Datasource;
using System;
using System.Collections.Generic;

namespace OpenDCP.Framework.Configuration.Model.Entities.ModuleSettings
{
    [Obsolete]
    public class ModuleDTO
    {
        //ToDo check usage was ID
        public int Id { get; set; }
        //ToDo check usage was IsEnable
        public bool IsEnabled { get; set; }
        //ToDo check usage was Name
        public string Name { get; set; }
        //ToDo check usage was SiteID
        public int SiteId { get; set; }
        public List<DataTypeDTO> DataTypes { get; set; }
        //ToDo check usage was RConnection
        public CalculationNodeConnectionDTO Connection { get; set; }
    }
}
