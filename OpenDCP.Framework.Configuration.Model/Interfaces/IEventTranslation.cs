using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDCP.Framework.Configuration.Model.Interfaces
{

    /// <summary>
    /// Defines a generic contract for interacting with and navigating a hierarchical tree structure.
    /// </summary>
    /// <typeparam name="T">The type of the node element in the tree.</typeparam>
    public interface IEventTranslation
    {
        /// <summary>
        /// Asynchronously searches for nodes that match a specific set of metadata attributes.
        /// </summary>
        /// <param name="attributes">A dictionary of key-value pairs representing the attributes to filter by.</param>
        /// <returns>A task representing the asynchronous operation, containing a list of matching elements.</returns>
        Task<List<string>> FindByAttributesAsync(Dictionary<string, object> attributes);

        /// <summary>
        /// Asynchronously searches for nodes that match a specific set of metadata attributes.
        /// </summary>
        /// <param name="attributes">A dictionary of key-value pairs representing the attributes to filter by.</param>
        /// <returns>A task representing the asynchronous operation, containing a list of matching elements.</returns>
        Task<Dictionary<string, List<string>>> FindByAttributesAsync(Dictionary<string, Dictionary<string, object>> attributes);

        /// <summary>
        /// Asynchronously retrieves all metadata attributes associated with a specific node.
        /// </summary>
        /// <param name="id">The unique identifier of the node.</param>
        /// <returns>A task representing the asynchronous operation, containing a dictionary of attributes.</returns>
        Task<Dictionary<string, object>> GetAttribtuesAsync(string id);

        /// <summary>
        /// Asynchronously retrieves all metadata attributes associated with a specific node.
        /// </summary>
        /// <param name="id">The unique identifier of the node.</param>
        /// <returns>A task representing the asynchronous operation, containing a dictionary of attributes.</returns>
        Task<Dictionary<string, Dictionary<string, object>>> GetAttribtuesAsync(List<string> id);
    }
}
