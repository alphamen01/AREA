using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using AREA.Interfaces;
using AREA.Models;
using AREA.Context;

namespace AREA.Providers
{
    public class SqlServerClienteProvider : IClienteProvider
    {
        private readonly AreaDbContext context;

        public SqlServerClienteProvider(AreaDbContext context)
        {
            this.context = context;
        }

        public async Task<ICollection<Cliente>> GetAllAsync()
        {
            var results = await context.Clientes
                                .Include(c => c.Areas)
                                .ToListAsync();
            return results;
        }

        public async Task<Cliente> GetAsync(int id)
        {
            var result = await context.Clientes.FirstOrDefaultAsync(c =>
            c.id_cliente == id);
            return result;
        }
    }

}
