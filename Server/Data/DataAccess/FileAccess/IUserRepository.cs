using System.Collections.Generic;
using Server.Data.Models;

namespace Server.Data.DataAccess.FileAccess
{
    public interface IUserRepository
    {
        public IEnumerable<User> GetUsers();
    }
}