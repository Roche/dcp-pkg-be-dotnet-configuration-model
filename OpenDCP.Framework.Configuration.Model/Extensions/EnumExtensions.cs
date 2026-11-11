using OpenDCP.Framework.Configuration.Model.Attributes;
using System;
using System.ComponentModel;

namespace OpenDCP.Framework.Configuration.Model.Extensions
{
    public static class EnumExtensions
    {
        public static T GetAttribute<T>(this Enum value) where T : Attribute
        {
            var type = value.GetType();
            var memberInfo = type.GetMember(value.ToString());
            var attributes = memberInfo[0].GetCustomAttributes(typeof(T), false);
            return attributes.Length > 0
              ? (T)attributes[0]
              : null;
        }
        public static string ToCalculationNodeName(this Enum value)
        {
            var attribute = value.GetAttribute<CalculationTypeNameAttribute>();
            return attribute == null ? value.ToString() : attribute.CalculationTypeName;
        }

        public static string ToName(this Enum value)
        {
            var attribute = value.GetAttribute<DescriptionAttribute>();
            return attribute == null ? value.ToString() : attribute.Description;
        }
    }
}
