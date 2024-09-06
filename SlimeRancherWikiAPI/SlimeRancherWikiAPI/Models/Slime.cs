using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SlimeRancherWikiAPI.Models
{
    public class Slime
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }

        public string? FavFoodId { get; set; }

        [ForeignKey("FavFoodId")]
        public Food? FavFood { get; set; }
        public string? ToyId { get; set; }

        [ForeignKey("ToyId")]
        public Toy? Toy { get; set; }

        public string? PlortId { get; set; }

        [ForeignKey("PlortId")]
        public Plort? Plort { get; set; }
        public ICollection<SlimeDiet>? SlimeDiet { get; set; }
        public ICollection<SlimeLocation> SlimeLocation { get; set; }

    }
}
