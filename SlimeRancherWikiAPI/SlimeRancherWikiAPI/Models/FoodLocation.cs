using System.ComponentModel.DataAnnotations.Schema;

namespace SlimeRancherWikiAPI.Models
{
    public class FoodLocation
    {
        public string LocationId { get; set; }

        [ForeignKey("LocationId")]
        public Location Location { get; set; }
        public string FoodId { get; set; }

        [ForeignKey("FoodId")]
        public Food Food { get; set; }
    }
}
