using System.ComponentModel.DataAnnotations.Schema;

namespace SlimeRancherWikiAPI.Models
{
    public class SlimeLocation
    {
        public string SlimeId { get; set; }

        [ForeignKey("SlimeId")]
        public Slime Slime { get; set; }
        public string LocationId { get; set; }

        [ForeignKey("LocationId")]
        public Location Location { get; set; }
    }
}
