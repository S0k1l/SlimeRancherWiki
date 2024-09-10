using Microsoft.EntityFrameworkCore;
using SlimeRancherWikiAPI.Data;
using SlimeRancherWikiAPI.Interfaces;
using SlimeRancherWikiAPI.Models;

namespace SlimeRancherWikiAPI.Repository
{
    public class DietRepository : IDietRepository
    {
        private readonly AppDbContext _context;

        public DietRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Diet>> GetAllDiets()
        {
            return await _context.Diets
                .Include(d => d.Foods)
                .ToListAsync();
        }

        public async Task<Diet> GetFruitDiet()
        {
            return await _context.Diets
                .Where(d => d.Name == "Фрукти")
                .Include(d => d.Foods)
                .FirstOrDefaultAsync();
        }

        public async Task<Diet> GetMeatDiet()
        {
            return await _context.Diets
                .Where(d => d.Name == "М'ясо")
                .Include(d => d.Foods)
                .FirstOrDefaultAsync();
        }

        public async Task<Diet> GetViggieDiet()
        {
            return await _context.Diets
                .Where(d => d.Name == "Овочі")
                .Include(d => d.Foods)
                .FirstOrDefaultAsync();
        }
    }
}
