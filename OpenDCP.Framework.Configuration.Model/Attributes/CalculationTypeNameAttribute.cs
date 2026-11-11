using System;

namespace OpenDCP.Framework.Configuration.Model.Attributes
{
    public class CalculationTypeNameAttribute : Attribute
    {
        public string CalculationTypeName { get; private set; }
        public CalculationTypeNameAttribute(string type)
        {
            CalculationTypeName = type;
        }
    }
}
