using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SlimeRancherWikiAPI.Models
{
    public class Plort
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public int MinPrice { get; set; }
        public int AvgPrice { get; set; }
        public int MaxPrice { get; set; }
        public Slime? Slime { get; set; }
    }
}
