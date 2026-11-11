using Newtonsoft.Json;
using System;

namespace OpenDCP.Framework.Configuration.Model.Entities.CalculationNode
{
    [Obsolete]
    public class CalculationNodeConnectionDTO
    {
        [JsonProperty("RserverBaseURL")]
        public string BaseURL { get; set; }
        [JsonProperty("RserverLibPath")]
        public string LibraryPath { get; set; }
        [JsonProperty("RUser")]
        public string User { get; set; }
        [JsonProperty("RPassword")]
        public string Password { get; set; }
    }
}
