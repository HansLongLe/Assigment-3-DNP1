using System.Collections.Generic;
using System.Threading.Tasks;
using Client.Models;

namespace Client.Data {
public interface IAdultsService {
    Task<IList<Adult>> GetAdultsAsync();
    Task AddAdultAsync(Adult adult);
}
}