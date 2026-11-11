namespace OpenDCP.Framework.Configuration.Model.Constants.Datasource
{
    public enum DataType : byte
    {
        /// <summary>
        /// Provides site hierarchy, sensor telemetry and batch context
        /// Obs
        /// </summary>
        EquipmentData = 1,
        /// <summary>
        /// Design of experiment runs and projects
        /// </summary>
        ExperimentData = 2,
        /// <summary>
        /// CQA, KPIs and bioburdern for product/process quality attributes
        /// </summary>
        ProcessMonitoringData = 3,
        /// <summary>
        /// Document meta data (status, author, etc.) and access to the document themself
        /// </summary>
        EDMS = 4,
        /// <summary>
        /// Measurements from analytical devices characterizing a specific batch
        /// </summary>
        AnalyticalData = 5,
        /// <summary>
        /// Access to product related master data (product codes, families, etc.)
        /// </summary>
        MasterData = 6,
        /// <summary>
        /// Tracing a batch via it's geanology
        /// </summary>
        BatchGenealogy = 7,
        /// <summary>
        /// Information on raw materials
        /// </summary>
        RawMaterials = 8,
        /// <summary>
        /// The logical strucutre and asset related information
        /// </summary>
        AssetHierarchy = 9,
        /// <summary>
        /// The context on when a specifc process is running on an asset
        /// </summary>
        EventframeContext = 10,
        /// <summary>
        /// Sensor telemetry data such as temperature measurements, etc-
        /// </summary>
        SensorTelemetry = 11,
        /// <summary>
        /// Information on alarms, their occurence, etc.
        /// </summary>
        Alarms = 12,
        /// <summary>
        /// Information on available recipies and thier structure
        /// </summary>
        RecipeInformation = 13,
        /// <summary>
        /// Spectral data from any source, such as HPLC (chromatography) or fluorescence, etc.
        /// </summary>
        SpectralData = 14,
        /// <summary>
        /// Quality Events (Deviations, CAPAs, etc.)
        /// </summary>
        QualityEventsData = 15,
    }

}
