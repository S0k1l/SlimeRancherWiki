using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SlimeRancherWikiAPI.Models
{
    public class Food
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public Slime? Slime { get; set; }
        public ICollection<DietFood> DietFood { get; set; }
        public ICollection<FoodLocation> FoodLocation { get; set; }
    }
}
