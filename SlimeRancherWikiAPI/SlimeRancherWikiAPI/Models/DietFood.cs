using System.ComponentModel.DataAnnotations.Schema;

namespace SlimeRancherWikiAPI.Models
{
    public class DietFood
    {
        public string DietId { get; set; }

        [ForeignKey("DietId")]
        public Diet Diet { get; set; }
        public string FoodId { get; set; }

        [ForeignKey("FoodId")]
        public Food Food { get; set; }
    }
}
