using SlimeRancherWikiAPI.Models;

namespace SlimeRancherWikiAPI.Interfaces
{
    public interface IDietRepository
    {
        Task<Diet> GetFruitDiet();
        Task<Diet> GetViggieDiet();
        Task<Diet> GetMeatDiet();
        Task<IEnumerable<Diet>> GetAllDiets();
    }
}
