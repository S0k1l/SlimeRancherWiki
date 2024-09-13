using SlimeRancherWikiAPI.Models;

namespace SlimeRancherWikiAPI.Interfaces
{
    public interface IToyRepository
    {
        Task<IEnumerable<Toy>> GetAllToysAsync();
        Task<IEnumerable<Toy>> GetAllToysDetailsAsync();
    }
}
