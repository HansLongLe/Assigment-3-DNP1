using System.Threading.Tasks;
using Client.Models;

namespace Client.Data
{
    public interface IUserService
    {
        public Task<bool> GetResult(User user);
    }
}