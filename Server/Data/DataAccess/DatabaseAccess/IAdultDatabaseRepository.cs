using System.Collections.Generic;
using System.Threading.Tasks;
using Server.Data.Models;

namespace Server.Data.DataAccess.DatabaseAccess
{
    public interface IAdultDatabaseRepository
    {
        public IList<Adult> GetAdults();
        public Task AddAdult(Adult adult);
    }
}