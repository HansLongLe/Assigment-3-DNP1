using System.Linq;
using Server.Data.DataAccess;
using Server.Data.DataAccess.DatabaseAccess;


namespace Server.Logic
{
    public class Verifier : IVerifier
    {
        private readonly IUserDatabaseRepository _userRepository;

        public Verifier(DataFactory dataFactory)
        {
            _userRepository = dataFactory.UserDatabaseRepository;
        }
        public bool Authorize(string username, string password)
        {
            return _userRepository.GetUsers().Any(user => user.Username.Equals(username) && user.Password.Equals(password));
        }
    }
}