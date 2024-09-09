namespace SlimeRancherWikiAPI.Dto
{
    public class LocationDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public List<ItemDto>? Fruits { get; set; }
        public List<ItemDto>? Veggies { get; set; }
        public List<ItemDto>? Meats { get; set; }
        public List<ItemDto>? Slimes { get; set; }

    }
}
