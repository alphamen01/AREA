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
    public class SqlServerAreaProvider : IAreaProvider
    {
        private readonly AreaDbContext context;

        public SqlServerAreaProvider(AreaDbContext context)
        {
            this.context = context;
        }

        public async Task<bool> AddAsync(Area area)
        {
            
                context.Areas.Add(area);
                var result = await context.SaveChangesAsync();
                return result == 1;
            
            
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var result = context.Areas.Where(a => a.id_area == id).FirstOrDefault();
            if (result == null)
            {
                return false;
            }
            else
            {
                context.Areas.Remove(result);
                await context.SaveChangesAsync();
                return true;
            }           
        }

        public async Task<ICollection<Area>> GetAllAsync()
        {
            var results = await context.Areas
                                .Include(a => a.ClienteFK)
                                .ToListAsync();
            return results;
        }

        public async Task<Area> GetAsync(int id)
        {
            var result = await context.Areas
                               .Include (a => a.ClienteFK)
                               .FirstOrDefaultAsync(a =>
            a.id_area == id);
            return result;
        }

        public async Task<bool> UpdateAsync(int id, Area area)
        {
            context.Areas.Update(area);
            var result = await context.SaveChangesAsync();
            return result == 1;
        }
    }

}
