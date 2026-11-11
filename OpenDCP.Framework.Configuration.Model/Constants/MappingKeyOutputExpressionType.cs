namespace OpenDCP.Framework.Configuration.Model.Constants
{
    /// <summary>
    /// Specifies the target protocol or query language format for a mapping key's output expression.
    /// </summary>
    public enum MappingKeyOutputExpressionType : byte
    {
        /// <summary>
        /// Indicates that the expression should be formatted as a SQL-compliant query or clause.
        /// </summary>
        SQL = 1,
        /// <summary>
        /// Indicates that the expression should be formatted for use in a RESTful API request, 
        /// typically as a URL path, query parameter, or request body field.
        /// </summary>
        REST = 2
    }
}
