using Microsoft.EntityFrameworkCore;
using SlimeRancherWikiAPI.Data;
using SlimeRancherWikiAPI.Interfaces;
using SlimeRancherWikiAPI.Models;

namespace SlimeRancherWikiAPI.Repository
{
    public class ToyRepository : IToyRepository
    {
        private readonly AppDbContext _context;

        public ToyRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Toy>> GetAllToysAsync()
        {
            return await _context.Toys.ToListAsync();
        }

        public async Task<IEnumerable<Toy>> GetAllToysDetailsAsync()
        {
            return await _context.Toys
                .Include(t => t.Slime)
                .ToListAsync();
        }
    }
}
