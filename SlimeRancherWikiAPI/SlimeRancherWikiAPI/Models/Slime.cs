using System.ComponentModel.DataAnnotations;

namespace SlimeRancherWikiAPI.Models
{
    public class Slime
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public Food? FavFood { get; set; }
        public Toy? Toy { get; set; }
        public Plort? Plort { get; set; }
        public ICollection<SlimeDiet>? SlimeDiet { get; set; }
        public ICollection<SlimeLocation> SlimeLocation { get; set; }

    }
}
