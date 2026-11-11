namespace OpenDCP.Framework.Configuration.Model.Constants.MessageDelivery
{
    /// <summary>
    /// Specifies the communication medium used for delivering system notifications and messages.
    /// </summary>
    public enum MessageDeliveryChannelType : byte
    {
        /// <summary>
        /// Indicates that the message should be delivered as an email via a Simple Mail Transfer Protocol (SMTP) server.
        /// </summary>
        Mail = 1,
    }
}
