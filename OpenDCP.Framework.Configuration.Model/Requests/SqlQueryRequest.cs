using System.Collections.Generic;

namespace OpenDCP.Framework.Configuration.Model.Requests
{
    /// <summary>
    /// A SQL query and its parameters.
    /// </summary>
    public class SqlQueryRequest
    {
        /// <summary>The SQL query to execute.</summary>
        public string Query { get; set; }

        /// <summary>The query's parameters, keyed by name.</summary>
        public Dictionary<string, string> QueryParameters { get; set; }
    }
}
