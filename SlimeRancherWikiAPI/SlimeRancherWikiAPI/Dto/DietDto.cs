namespace SlimeRancherWikiAPI.Dto
{
    public class DietDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public List<ItemDto>? Food { get; set; }
    }
}
