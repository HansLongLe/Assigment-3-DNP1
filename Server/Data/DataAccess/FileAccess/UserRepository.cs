using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Server.Data.Models;

namespace Server.Data.DataAccess.FileAccess
{
    public class UserRepository : IUserRepository
    {
        private readonly IList<User> _users;
        private readonly string _usersFile = Directory.GetCurrentDirectory() + "\\data\\users.json";

        public UserRepository()
        {
            _users = File.Exists(_usersFile) ? ReadData<User>() : new List<User>();
        }
        
        private IList<T> ReadData<T>()
        {
            using var jsonReader = File.OpenText(_usersFile);
            return JsonSerializer.Deserialize<List<T>>(jsonReader.ReadToEnd());
        }

        public IEnumerable<User> GetUsers()
        {
            return _users;
        }

    }
}