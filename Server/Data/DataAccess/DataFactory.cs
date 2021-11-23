using Server.Data.DataAccess.DatabaseAccess;
using Server.Data.DataAccess.FileAccess;

namespace Server.Data.DataAccess
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class DataFactory
    {
        public IAdultRepository AdultRepository { get; } = new AdultRepository();
        public IUserRepository UserRepository { get; } = new UserRepository();
        public IAdultDatabaseRepository AdultDatabaseRepository { get; } = new AdultDatabaseRepository();
        public IUserDatabaseRepository UserDatabaseRepository { get; } = new UserDatabaseRepository();
    }
}