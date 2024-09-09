namespace SlimeRancherWikiAPI.Dto
{
    public class PlortDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public int MinPrice { get; set; }
        public int AvgPrice { get; set; }
        public int MaxPrice { get; set; }
        public ItemDto Slime { get; set; }
    }
}
