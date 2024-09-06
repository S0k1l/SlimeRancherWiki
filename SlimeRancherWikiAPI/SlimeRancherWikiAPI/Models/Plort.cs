using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SlimeRancherWikiAPI.Models
{
    public class Plort
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public int MinPrice { get; set; }
        public int AvgPrice { get; set; }
        public int MaxPrice { get; set; }
        public string SlimeId { get; set; }

        [ForeignKey("SlimeId")]
        public Slime Slime { get; set; }
    }
}
