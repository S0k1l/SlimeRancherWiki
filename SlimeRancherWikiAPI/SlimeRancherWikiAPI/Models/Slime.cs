using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SlimeRancherWikiAPI.Models
{
    public class Slime
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }

        public int? FavFoodId { get; set; }

        [ForeignKey("FavFoodId")]
        public Food? FavFood { get; set; }
        public int? ToyId { get; set; }

        [ForeignKey("ToyId")]
        public Toy? Toy { get; set; }

        public int? PlortId { get; set; }

        [ForeignKey("PlortId")]
        public Plort? Plort { get; set; }

        public int? DietId { get; set; }

        [ForeignKey("DietId")]
        public Diet? Diet { get; set; }

        //public ICollection<SlimeDiet>? SlimeDiet { get; set; }
        public ICollection<SlimeLocation> SlimeLocation { get; set; }

    }
}
