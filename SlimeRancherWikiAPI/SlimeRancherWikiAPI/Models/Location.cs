using System.ComponentModel.DataAnnotations;

namespace SlimeRancherWikiAPI.Models
{
    public class Location
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public ICollection<FoodLocation> FoodLocation { get; set; }
        public ICollection<SlimeLocation> SlimeLocation { get; set; }
    }
}
