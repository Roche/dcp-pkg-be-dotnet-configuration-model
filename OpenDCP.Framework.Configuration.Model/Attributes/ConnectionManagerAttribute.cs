using OpenDCP.Framework.Configuration.Model.Constants.Datasource;
using System;

namespace OpenDCP.Framework.Configuration.Model.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class ConnectionManagerAttribute : Attribute
    {
        public RequestPipelineAction Action { get; }

        public ConnectionManagerAttribute(RequestPipelineAction action)
        {
            Action = action;
        }
    }
}
