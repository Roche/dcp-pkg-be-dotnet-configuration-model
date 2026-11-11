using OpenDCP.Framework.Configuration.Model.Attributes;
using System.ComponentModel;

namespace OpenDCP.Framework.Configuration.Model.Constants.Datasource
{
    /// <summary>
    /// Specifies the supported external data source connection types within the system.
    /// </summary>
    public enum ConnectionType : byte
    {
        /// <summary>
        /// Connection to OSI Soft PI Historian systems.
        /// </summary>
        [Description("OSI Soft PI")]
        [CalculationTypeNameAttribute("pi")]
        OSISoftPI = 1,
        /// <summary>
        /// Connection to Google Cloud Platform (BigQuery).
        /// </summary>
        [Description("Google Cloud Platform")]
        [CalculationTypeNameAttribute("bq")]
        GCP = 2,
        /// <summary>
        /// Connection to SynTQ PAT (Process Analytical Technology) systems.
        /// </summary>
        [Description("SynTQ")]
        [CalculationTypeNameAttribute("syntq")]
        SynTQ = 3,
        /// <summary>
        /// Connection to ReMIX database systems via SQL.
        /// </summary>
        [Description("ReMIX")]
        [CalculationTypeNameAttribute("sql")]
        ReMIX = 4,
        /// <summary>
        /// Connection to Condor data systems.
        /// </summary>
        [Description("Condor")]
        [CalculationTypeNameAttribute("condor")]
        Condor = 5,
        /// <summary>
        /// Connection to PTDC systems via BigQuery.
        /// </summary>
        [Description("PTDC via BG")]
        [CalculationTypeNameAttribute("bq")]
        PTDC = 6,
        /// <summary>
        /// Connection to Prozell database systems via SQL.
        /// </summary>
        [Description("Prozell")]
        [CalculationTypeNameAttribute("sql")]
        Prozell = 7,
        /// <summary>
        /// Mock datasource used for testing and development purposes.
        /// </summary>
        [Description("MockDatasource")]
        [CalculationTypeNameAttribute("mock")]
        Mock = 8,
        /// <summary>
        /// Connection to Snowflake Data Warehouse.
        /// </summary>
        [Description("Snowflake")]
        [CalculationTypeNameAttribute("snowflake")]
        Snowflake = 9,
        /// <summary>
        /// Connection to SQL databases with dynamic or non-fixed schemas.
        /// </summary>
        [Description("SchemalessSQL")]
        [CalculationTypeNameAttribute("sql")]
        SchemalessSQL = 10,
        /// <summary>
        /// Connection to the Data Refinery platform via BigQuery.
        /// </summary>
        [Description("Data Refinery")]
        [CalculationTypeNameAttribute("bq")]
        DataRefinery = 11,
        /// <summary>
        /// Connection to GRED (Global Research Event Data) via BigQuery.
        /// </summary>
        [Description("GRED")]
        [CalculationTypeNameAttribute("bq")]
        GRED = 12,
        /// <summary>
        /// Connection to Basecamp 2.0 via Snowflake.
        /// </summary>
        [Description("Basecamp 2.0")]
        [CalculationTypeNameAttribute("snowflake")]
        Basecamp20 = 13,
        /// <summary>
        /// Connection to Roche Analytics Worksheet version 2 via SQL.
        /// </summary>
        [Description("Roche Analytics Worksheet")]
        [CalculationTypeNameAttribute("sql")]
        RAW2 = 14,
        /// <summary>
        /// Connection to the Tetralake data platform.
        /// </summary>
        [Description("Tetralake")]
        [CalculationTypeNameAttribute("tetralake")]
        Tetralake = 15,
        /// <summary>
        /// Connection to the ProGraf visualization/data system.
        /// </summary>
        [Description("ProGraf")]
        [CalculationTypeNameAttribute("prograf")]
        ProGraf = 16,
        /// <summary>
        /// Connection to the KRIS data management system.
        /// </summary>
        [Description("KRIS")]
        [CalculationTypeNameAttribute("kris")]
        KRIS = 17,
    }
}
