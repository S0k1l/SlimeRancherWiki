using Microsoft.EntityFrameworkCore;
using SlimeRancherWikiAPI.Data;
using SlimeRancherWikiAPI.Interfaces;
using SlimeRancherWikiAPI.Models;

namespace SlimeRancherWikiAPI.Repository
{
    public class PlortRepository : IPlortRepository
    {
        private readonly AppDbContext _context;

        public PlortRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Plort>> GetAllPlortsAsync()
        {
            return await _context.Plorts.ToListAsync();
        }

        public async Task<IEnumerable<Plort>> GetAllPlortsDetailsAsync()
        {
            return await _context.Plorts
                .Include(p => p.Slime)
                .ToListAsync();
        }
    }
}
