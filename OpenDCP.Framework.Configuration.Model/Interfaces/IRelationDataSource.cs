using OpenDCP.Framework.Configuration.Model.Requests;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace OpenDCP.Framework.Configuration.Model.Interfaces
{
    /// <summary>
    /// A datasource that can be queried to find related records.
    /// </summary>
    public interface IRelationDataSource
    {
        /// <summary>
        /// Runs the given query and returns matching ids, keyed by source id.
        /// </summary>
        /// <param name="query">The compiled query to execute.</param>
        /// <param name="cancellationToken">A token to cancel the operation.</param>
        /// <returns>Matched ids grouped by source id, or empty if none found.</returns>
        Task<Dictionary<string, List<string>>> FindByQueryAsync(string query, CancellationToken cancellationToken = default);

        /// <summary>
        /// Executes the given SQL query and maps the results to the specified type.
        /// </summary>
        /// <typeparam name="T">The type to map each result row to.</typeparam>
        /// <param name="sqlQueryRequest">The SQL query and parameters to execute.</param>
        /// <param name="cancellationToken">A token to cancel the operation.</param>
        /// <returns>The mapped results, or empty if none found.</returns>
        Task<IList<T>> ExecuteSqlAsync<T>(SqlQueryRequest sqlQueryRequest, CancellationToken cancellationToken = default) where T : new();
    }
}
