namespace OpenDCP.Framework.Configuration.Model.Entities.ConnectionBridge
{
    public class MappingKeyReplaceOperator : MappingKeyOperator
    {
        private readonly string _pattern;
        private readonly string _replacement;

        public MappingKeyReplaceOperator(string definiton)
        {
            var def = definiton.Split('|');
            _pattern = def[0];
            _replacement = def[1];
        }
        public override string Convert2SQL(string keyName)
        {
            return $"REPLACE({keyName},'{_pattern}','{_replacement}')";
        }

        public override string Apply(string stringValue)
        {
            return stringValue.Replace(_pattern, _replacement);
        }

        public override bool Validate()
        {
            return true;
        }
    }
}
