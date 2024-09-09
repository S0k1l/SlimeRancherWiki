using SlimeRancherWikiAPI.Models;

namespace SlimeRancherWikiAPI.Interfaces
{
    public interface IPlortRepository
    {
        Task<IEnumerable<Plort>> GetAllPlortsAsync();
        Task<IEnumerable<Plort>> GetAllPlortsDetailsAsync();
    }
}
