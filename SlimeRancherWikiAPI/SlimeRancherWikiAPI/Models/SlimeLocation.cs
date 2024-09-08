using System.ComponentModel.DataAnnotations.Schema;

namespace SlimeRancherWikiAPI.Models
{
    public class SlimeLocation
    {
        public int SlimeId { get; set; }

        [ForeignKey("SlimeId")]
        public Slime Slime { get; set; }
        public int LocationId { get; set; }

        [ForeignKey("LocationId")]
        public Location Location { get; set; }
    }
}
