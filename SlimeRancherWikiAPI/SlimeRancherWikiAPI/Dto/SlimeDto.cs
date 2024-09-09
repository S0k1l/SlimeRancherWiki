namespace SlimeRancherWikiAPI.Dto
{
    public class SlimeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public ItemDto? Toy { get; set; } = null!;
        public List<ItemDto> Locations { get; set; }
        public ItemDto? Diet { get; set; } = null!;
        public ItemDto? FavFood { get; set; } = null!;
        public ItemDto? Plort { get; set; } = null!;



    }
}
