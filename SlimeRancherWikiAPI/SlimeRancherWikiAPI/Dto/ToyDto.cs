namespace SlimeRancherWikiAPI.Dto
{
    public class ToyDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public int Price { get; set; }
        public ItemDto? Slime { get; set; }
    }
}
