using Microsoft.EntityFrameworkCore;
using SlimeRancherWikiAPI.Data;
using SlimeRancherWikiAPI.Interfaces;
using SlimeRancherWikiAPI.Models;

namespace SlimeRancherWikiAPI.Repository
{
    public class SlimeRepository : ISlimeRepository
    {
        private readonly AppDbContext _context;

        public SlimeRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Slime>> GetAllSlimesAsync()
        {
            return await _context.Slimes.ToListAsync();
        }

        public async Task<Slime> GetSlimeAsync(int id)
        {
            return await _context.Slimes
                .Where(s => s.Id == id)
                .Include(s => s.FavFood)
                .Include(s => s.Toy)
                .Include(s => s.Diet)
                .Include(s => s.Plort)
                .Include(s => s.SlimeLocation)
                        .ThenInclude(sl => sl.Location)
                .FirstOrDefaultAsync();
        }
    }
}
