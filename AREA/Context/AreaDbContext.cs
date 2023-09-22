using Microsoft.EntityFrameworkCore;
using AREA.Models;

namespace AREA.Context
{
	public class AreaDbContext: DbContext
	{
        
        public AreaDbContext(DbContextOptions<AreaDbContext>  options): base(options)
        {
            
        }

        public DbSet<Area> Areas { get; set; }
        public DbSet<Cliente> Clientes { get;set; }  
	}
}
