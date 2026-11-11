using OpenDCP.Framework.Configuration.Model.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace OpenDCP.Framework.Configuration.Model.Entities.ConnectionBridge
{
    public class MappingKey
    {
        readonly List<MappingKeyField> _keyFields = new List<MappingKeyField>();
        readonly string _defintion;

        public MappingKey(string defintion)
        {
            _defintion = defintion;
            foreach (Match m in Regex.Matches(defintion, @"\{(.*?)\}"))
            {
                _keyFields.Add(new MappingKeyField(m.Value));
            }
        }

        public virtual bool IsDynamic
        {
            get
            {
                return _keyFields.Any(kf => kf.IsDynamic);
            }
        }

        public string OperatorExpression(byte expressionType)
        {
            string expression = string.Empty;

            if (expressionType == (byte)MappingKeyOutputExpressionType.SQL)
            {
                expression = $"CONCAT('',{TemplateString()})";

                foreach (var keyField in _keyFields)
                {
                    expression = expression.Replace("{" + keyField.RawField() + "}", keyField.OperatorExpression(keyField.RawField()));
                }

                return expression;
            }
            else if (expressionType == (byte)MappingKeyOutputExpressionType.REST)
            {
                expression = _keyFields.FirstOrDefault().RawField();
            }
            else
            {
                throw new Exception("This is not supported");
            }

            return expression;
        }

        public bool Filter(List<EventFrameMappingKey> values)
        {
            foreach (var keyField in _keyFields.Where(kf => !kf.IsDynamic))
            {
                var valToCheck = values.FirstOrDefault(v => v.Name == keyField.RawField());
                if (valToCheck == null || valToCheck.Value != keyField.RawField())
                {
                    return false;
                }
            }
            return true;
        }
        public string Apply(List<EventFrameMappingKey> values)
        {
            string value = TemplateString();

            foreach (var keyField in _keyFields)
            {
                value = value.Replace("{" + keyField.RawField() + "}", keyField.ApplyOperators(values.Where(x => x.Name == keyField.RawField()).Select(x => x.Value).FirstOrDefault()));
            }

            return value;

        }

        public bool Validate()
        {
            return true;
        }

        public List<string> RawFields()
        {
            return _keyFields.Select(x => x.RawField()).ToList();
        }

        private string TemplateString()
        {
            return Regex.Replace(_defintion, @"\[.*?\]", "");
        }
    }
}
