namespace Server.Logic
{
    public interface IVerifier
    {
        public bool Authorize(string username, string password);
    }
}