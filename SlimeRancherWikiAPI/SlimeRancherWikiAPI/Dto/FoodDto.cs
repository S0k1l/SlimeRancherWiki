namespace SlimeRancherWikiAPI.Dto
{
    public class FoodDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public ItemDto? Slime { get; set; }
        public List<ItemDto>? Locations { get; set; }
        public ItemDto? Diet { get; set; }
    }
}
