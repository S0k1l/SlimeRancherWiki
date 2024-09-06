using System.ComponentModel.DataAnnotations.Schema;

namespace SlimeRancherWikiAPI.Models
{
    public class SlimeDiet
    {
        public string SlimeId { get; set; }

        [ForeignKey("SlimeId")]
        public Slime Slime { get; set; }
        public string DietId { get; set; }

        [ForeignKey("DietId")]
        public Diet Diet { get; set; }

    }
}
