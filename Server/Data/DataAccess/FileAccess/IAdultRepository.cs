using System.Collections.Generic;
using System.Threading.Tasks;
using Server.Data.Models;

namespace Server.Data.DataAccess.FileAccess
{
    public interface IAdultRepository
    {
        public IEnumerable<Adult> GetAdults();
        public Task AddAdult(Adult adult);
    }
}