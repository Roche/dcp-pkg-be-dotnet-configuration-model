namespace OpenDCP.Framework.Configuration.Model.Constants.MessageDelivery
{
    /// <summary>
    /// Specifies the encoding and structural format of the message content for delivery.
    /// </summary>
    public enum MessageDeliveryMessageFormat : byte
    {
        /// <summary>
        /// Indicates that the message is sent as plain text without any specialized formatting.
        /// </summary>
        Text = 1,
        /// <summary>
        /// Indicates that the message body is structured as a JSON string.
        /// </summary>
        Json = 2,
        /// <summary>
        /// Indicates that the message body contains HTML markup, allowing for rich text formatting, links, and images in email clients.
        /// </summary>
        HTML = 3,
    }
}
