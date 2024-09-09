using SlimeRancherWikiAPI.Models;

namespace SlimeRancherWikiAPI.Interfaces
{
    public interface ISlimeRepository
    {
        Task<IEnumerable<Slime>> GetAllSlimesAsync();
        Task<Slime> GetSlimeAsync(int id);

    }
}
