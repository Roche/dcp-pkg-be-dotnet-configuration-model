namespace OpenDCP.Framework.Configuration.Model.Constants.CalculationNode
{
    /// Represents the type of calculation node used in the system.
    /// </summary>
    public enum CalculationNodeType : byte
    {
        /// <summary>
        /// Represents an OpenCPU calculation node, based on the R language
        /// </summary>
        OpenCPU = 1,
        /// <summary>
        /// Represents an Dataiku scenario - reading the results from the snowflake datasets
        /// </summary>
        Dataiku = 2,
    }
}
