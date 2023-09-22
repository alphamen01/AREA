using System.Collections.Generic;
using System.Threading.Tasks;
using AREA.Models;

namespace AREA.Interfaces
{
    public interface IClienteProvider
    {
        Task<Cliente> GetAsync(int id);

        Task<ICollection<Cliente>> GetAllAsync();
    }
}
