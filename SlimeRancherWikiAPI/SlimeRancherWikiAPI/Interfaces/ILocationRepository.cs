using SlimeRancherWikiAPI.Models;

namespace SlimeRancherWikiAPI.Interfaces
{
    public interface ILocationRepository
    {
        Task<IEnumerable<Location>> GetAllLocationsAsync();
        Task<Location> GetLocationAsync(int id);
    }
}
