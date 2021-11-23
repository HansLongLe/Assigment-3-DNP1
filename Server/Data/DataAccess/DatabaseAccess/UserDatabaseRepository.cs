using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Server.Data.DataAccess.FileAccess;
using Server.Data.Models;

namespace Server.Data.DataAccess.DatabaseAccess
{
    public class UserDatabaseRepository : IUserDatabaseRepository
    {
        public UserDatabaseRepository()
        { 
            Task.Run(async ()=> await LoadDataFromFileToDatabase());
        }
        public IList<User> GetUsers()
        {
            using var dbContext = new Assigment3DbContext();
            return dbContext.Users.ToList();
        }

        public async Task AddUser(User user)
        {
            await using var dbContext =new Assigment3DbContext();
            await dbContext.Users.AddAsync(user);
            await dbContext.SaveChangesAsync();
        }
        private static async Task LoadDataFromFileToDatabase()
        {
            var userRepository = new UserRepository();
            await using var dbContext = new Assigment3DbContext();
            foreach (var user in userRepository.GetUsers())
            {
                dbContext.Users.AddIfNotExists(user, user1 => user1.Id == user.Id || (user1.Username == user.Username && user1.Password == user.Password));    
            }

            await dbContext.SaveChangesAsync();

        }
    }
}