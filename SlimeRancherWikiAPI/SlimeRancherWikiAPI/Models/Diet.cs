using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SlimeRancherWikiAPI.Models
{
    public class Diet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public ICollection<SlimeDiet> SlimeDiet { get; set; }
        public ICollection<DietFood> DietFood { get; set; }
    }
}
