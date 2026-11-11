using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace OpenDCP.Framework.Configuration.Model.Entities.ConnectionBridge
{
    public class MappingKeyField
    {
        readonly List<MappingKeyOperator> _operators = new List<MappingKeyOperator>();
        readonly string _name;

        public MappingKeyField(string defintion)
        {
            foreach (Match m in Regex.Matches(defintion, @"\[(.*?)\]"))
            {
                _operators.Add(new MappingKeyReplaceOperator(m.Groups[1].Value));
            }

            _name = Regex.Replace(defintion, @"\[.*?\]", "");
        }

        public virtual bool IsDynamic
        {
            get
            {
                return _name.Contains("{");
            }
        }

        public virtual string RawField()
        {
            return _name.Substring(1, _name.Length - 2);
        }
        public string ApplyOperators(string val)
        {
            foreach (var keyOperator in _operators)
            {
                val = keyOperator.Apply(val);
            }

            return val;
        }

        public string OperatorExpression(string val)
        {
            foreach (var keyOperator in _operators)
            {
                val = keyOperator.Convert2SQL(val);
            }

            return val;
        }

        public bool Validate()
        {
            return true;
        }
    }
}
