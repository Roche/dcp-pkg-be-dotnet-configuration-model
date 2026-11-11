namespace OpenDCP.Framework.Configuration.Model.Entities.ConnectionBridge
{
    public abstract class MappingKeyOperator
    {
        public abstract string Convert2SQL(string keyName);

        public abstract string Apply(string keyValue);

        public abstract bool Validate();
    }
}
