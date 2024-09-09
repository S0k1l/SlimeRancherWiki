using SlimeRancherWikiAPI.Models;

namespace SlimeRancherWikiAPI.Interfaces
{
    public interface IFoodRepository
    {
        Task<IEnumerable<Food>> GetFruits();
        Task<IEnumerable<Food>> GetVeggies();
        Task<IEnumerable<Food>> GetMeats();
        Task<Food> GetFoodDetails(int id);

    }
}
