using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SlimeRancherWikiAPI.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public ICollection<FoodLocation> FoodLocation { get; set; }
        public ICollection<SlimeLocation> SlimeLocation { get; set; }
    }
}
