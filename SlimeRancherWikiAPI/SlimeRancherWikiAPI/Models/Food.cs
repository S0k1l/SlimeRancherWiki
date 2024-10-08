﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SlimeRancherWikiAPI.Models
{
    public class Food
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public Slime? Slime { get; set; }
        public int DietId { get; set; }

        [ForeignKey("DietId")]
        public Diet Diet { get; set; }
        public ICollection<FoodLocation> FoodLocation { get; set; }
    }
}
