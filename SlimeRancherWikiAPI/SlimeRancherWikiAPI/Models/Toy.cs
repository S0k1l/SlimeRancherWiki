using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SlimeRancherWikiAPI.Models
{
    public class Toy
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public int Price { get; set; }
        public Slime? Slime { get; set; }
    }
}
