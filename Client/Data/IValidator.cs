namespace Client.Data
{
    public interface IValidator
    {
        public void Set(bool authorize);
        public bool GetAuthorization();
    }
}