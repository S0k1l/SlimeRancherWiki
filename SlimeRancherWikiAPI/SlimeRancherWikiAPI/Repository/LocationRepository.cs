using Microsoft.EntityFrameworkCore;
using SlimeRancherWikiAPI.Data;
using SlimeRancherWikiAPI.Interfaces;
using SlimeRancherWikiAPI.Models;

namespace SlimeRancherWikiAPI.Repository
{
    public class LocationRepository : ILocationRepository
    {
        private readonly AppDbContext _context;

        public LocationRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Location>> GetAllLocationsAsync()
        {
            return await _context.Locations.ToListAsync();
        }

        public Task<Location> GetLocationAsync(int id)
        {
            return _context.Locations
                .Where(l => l.Id == id)
                .Include(l => l.FoodLocation)
                    .ThenInclude(fl => fl.Food)
                        .ThenInclude(f => f.Diet)
                .Include(l => l.SlimeLocation)
                    .ThenInclude(sl => sl.Slime)
                .FirstOrDefaultAsync();
        }
    }
}
