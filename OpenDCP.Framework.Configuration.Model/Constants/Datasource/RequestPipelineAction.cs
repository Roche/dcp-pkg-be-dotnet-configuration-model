namespace OpenDCP.Framework.Configuration.Model.Constants.Datasource
{
    /// <summary>
    /// Specifies the type of processing action to be performed within the data request pipeline.
    /// </summary>
    /// <remarks>
    /// This enum is used by the connection manager to coordinate how data is collected, 
    /// modified, and aggregated across multiple data source providers.
    /// </remarks>
    public enum RequestPipelineAction : byte
    {
        /// <summary>
        /// Indicates an initial mapping phase where the request is distributed to relevant data sources.
        /// </summary>
        Map = 1,
        /// <summary>
        /// Indicates a data modification phase where raw results are converted into a standardized format.
        /// </summary>
        Transform = 2,
        /// <summary>
        /// Indicates an aggregation phase where results from multiple sources are combined into a single response.
        /// </summary>
        Reduce = 3,
        /// <summary>
        /// Indicates a data translation of identifiers from one system to another
        /// </summary>
        Translate = 4,
        /// <summary>
        /// Indicates a data decode of identifiers
        /// </summary>
        Decode = 5
    }
}
