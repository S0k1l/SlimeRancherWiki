using System.ComponentModel.DataAnnotations.Schema;

namespace SlimeRancherWikiAPI.Models
{
    public class FoodLocation
    {
        public int LocationId { get; set; }

        [ForeignKey("LocationId")]
        public Location Location { get; set; }
        public int FoodId { get; set; }

        [ForeignKey("FoodId")]
        public Food Food { get; set; }
    }
}
