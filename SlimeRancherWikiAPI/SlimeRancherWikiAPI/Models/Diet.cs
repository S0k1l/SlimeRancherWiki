using System.ComponentModel.DataAnnotations;

namespace SlimeRancherWikiAPI.Models
{
    public class Diet
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public ICollection<SlimeDiet> SlimeDiet { get; set; }
        public ICollection<DietFood> DietFood { get; set; }
    }
}
