using System.Collections.Generic;
using System.Threading.Tasks;
using AREA.Models;

namespace AREA.Interfaces
{
    public interface IAreaProvider
    {
        Task<ICollection<Area>> GetAllAsync();

        Task<Area> GetAsync(int id);

        Task<bool> UpdateAsync(int id, Area area);

        Task<bool> AddAsync(Area area);

        Task<bool> DeleteAsync(int id);


    }
}
