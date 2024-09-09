using Microsoft.EntityFrameworkCore;
using SlimeRancherWikiAPI.Data;
using SlimeRancherWikiAPI.Interfaces;
using SlimeRancherWikiAPI.Models;

namespace SlimeRancherWikiAPI.Repository
{
    public class FoodRepository : IFoodRepository
    {
        private readonly AppDbContext _context;

        public FoodRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Food> GetFoodDetails(int id)
        {
            return await _context.Foods
                .Where(f => f.Id == id)
                .Include(f => f.Slime)
                .Include(f => f.Diet)
                .Include(f => f.FoodLocation)
                    .ThenInclude(fl => fl.Location)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Food>> GetFruits()
        {
            return await _context.Foods
                .Where(f => f.Diet.Name == "Фрукти")
                .ToListAsync();
        }

        public async Task<IEnumerable<Food>> GetMeats()
        {
            return await _context.Foods
                .Where(f => f.Diet.Name == "М'ясо")
                .ToListAsync();
        }

        public async Task<IEnumerable<Food>> GetVeggies()
        {
            return await _context.Foods
                .Where(f => f.Diet.Name == "Овочі")
                .ToListAsync();
        }
    }
}
