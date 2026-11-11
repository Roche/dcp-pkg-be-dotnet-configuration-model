namespace OpenDCP.Framework.Configuration.Model.Entities.CalculationNode
{
    /// <summary>
    /// Data Transfer Object representing a file associated with a calculation node.
    /// </summary>
    public class CalculationNodeFileDTO
    {
        /// <summary>
        /// Gets or sets the binary content of the file.
        /// </summary>
        public byte[] FileContent { get; set; }
        /// <summary>
        /// Gets or sets the file extension (e.g., ".pdf", ".csv", ".xlsx").
        /// </summary>
        public string FileExtension { get; set; }
        /// <summary>
        /// Gets or sets the name of the file without the path.
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// Gets or sets the Multipurpose Internet Mail Extensions (MIME) type of the file.
        /// </summary>
        public string MimeType { get; set; }
    }
}
