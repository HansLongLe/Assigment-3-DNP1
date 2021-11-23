using System.Collections.Generic;
using System.Threading.Tasks;
using Server.Data.Models;

namespace Server.Data.DataAccess.DatabaseAccess
{
    public interface IUserDatabaseRepository
    {
        public IList<User> GetUsers();
        public Task AddUser(User user);
    }
}