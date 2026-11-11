using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDCP.Framework.Configuration.Model.Interfaces
{

    /// <summary>
    /// Defines a generic contract for interacting with and navigating a hierarchical tree structure.
    /// </summary>
    /// <typeparam name="T">The type of the node element in the tree.</typeparam>
    public interface ITreeNode<T>
    {
        /// <summary>
        /// Retrieves the unique identifier for a specific node element.
        /// </summary>
        /// <param name="el">The node element.</param>
        /// <returns>A unique identifier string.</returns>
        string GetId(T el);

        /// <summary>
        /// Retrieves a navigational link or reference path for a specific node element.
        /// </summary>
        /// <param name="el">The node element.</param>
        /// <returns>A string representing the link or path to the element.</returns>
        string GetLink(T el);

        /// <summary>
        /// Asynchronously retrieves the direct children of a node based on its link.
        /// </summary>
        /// <param name="link">The link or reference of the parent node.</param>
        /// <returns>A task representing the asynchronous operation, containing a list of child elements.</returns>
        Task<List<T>> GetChildrenAsync(string link);

        /// <summary>
        /// Asynchronously retrieves the direct parent of a node based on the child's identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the child node.</param>
        /// <returns>A task representing the asynchronous operation, containing the parent element.</returns>
        Task<T> GetParentAsync(string id);

        /// <summary>
        /// Asynchronously searches for a specific node by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier to search for.</param>
        /// <returns>A task representing the asynchronous operation, containing the found element.</returns>
        Task<T> FindByIdAsync(string id);

        /// <summary>
        /// Asynchronously navigates the tree to find a node based on a structured path of breadcrumbs.
        /// </summary>
        /// <param name="path">A list of tuples containing the identifier, role, and name of each node in the path sequence.</param>
        /// <returns>A task representing the asynchronous operation, containing the element found at the end of the path.</returns>
        Task<T> FindByPathAsync(List<(string id, string role, string name)> path);

        /// <summary>
        /// Asynchronously constructs the full path (breadcrumb trail) from the root to the specified node.
        /// </summary>
        /// <param name="id">The unique identifier of the target node.</param>
        /// <returns>A task representing the asynchronous operation, containing a list of path segments (id, role, name).</returns>
        Task<List<(string id, string role, string name)>> GetPathAsync(string id);

        /// <summary>
        /// Asynchronously searches for nodes that match a specific set of metadata attributes.
        /// </summary>
        /// <param name="attributes">A dictionary of key-value pairs representing the attributes to filter by.</param>
        /// <returns>A task representing the asynchronous operation, containing a list of matching elements.</returns>
        Task<List<T>> FindByAttributesAsync(Dictionary<string, object> attributes);

        /// <summary>
        /// Asynchronously retrieves all metadata attributes associated with a specific node.
        /// </summary>
        /// <param name="id">The unique identifier of the node.</param>
        /// <returns>A task representing the asynchronous operation, containing a dictionary of attributes.</returns>
        Task<Dictionary<string, object>> GetAttribtuesAsync(string id);
    }
}
