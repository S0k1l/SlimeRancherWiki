using Microsoft.AspNetCore.Mvc;
using SlimeRancherWikiAPI.Dto;
using SlimeRancherWikiAPI.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SlimeRancherWikiAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ILocationRepository _locationRepository;

        public LocationController(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        // GET: api/<LocationController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var Locations = await _locationRepository.GetAllLocationsAsync();
            var locationsDto = Locations
                .Select(l => new ItemDto { Id = l.Id, Name = l.Name, ImgUrl = l.ImgUrl })
                .ToList();
            return Ok(locationsDto.OrderBy(l => l.Name));
        }

        // GET api/<LocationController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if(!ModelState.IsValid) { return BadRequest(ModelState); }

            if(id <= 0 ) { return BadRequest("Invalid Id"); }

            var location = await _locationRepository.GetLocationAsync(id);

            if (location == null) { return NotFound(); }

            var foods = location.FoodLocation.Select(fl => fl.Food).ToList();
            foods = foods.Any() ? foods : null;

            List<ItemDto>? fruits = null;
            List<ItemDto>? veggies = null;
            List<ItemDto>? meats = null;

            if (foods != null) 
            {
                fruits = foods.Where(f => f.Diet.Name == "Фрукти")
                    .Select(f => new ItemDto
                    {
                        Id = f.Id,
                        Name = f.Name,
                        ImgUrl = f.ImgUrl,
                    })
                    .ToList();

                veggies = foods.Where(f => f.Diet.Name == "Овочі")
                    .Select(f => new ItemDto
                    {
                        Id = f.Id,
                        Name = f.Name,
                        ImgUrl = f.ImgUrl,
                    })
                    .ToList();

                meats = foods.Where(f => f.Diet.Name == "М'ясо")
                    .Select(f => new ItemDto
                    {
                        Id = f.Id,
                        Name = f.Name,
                        ImgUrl = f.ImgUrl,
                    })
                    .ToList();
            }

            var slimes = location.SlimeLocation?.Select(fl => fl.Slime).ToList();
            List<ItemDto>? slimesDto = null;

            if(slimes.Any())
            {
                slimesDto = slimes.Select(s => new ItemDto
                {
                    Id = s.Id,
                    Name = s.Name,
                    ImgUrl = s.ImgUrl
                })
                .ToList();
            }

            var locationDto = new LocationDto
            {
                Id = location.Id,
                Name = location.Name,
                ImgUrl = location.ImgUrl,
                Fruits = fruits,
                Veggies = veggies,
                Meats = meats,
                Slimes = slimesDto,
            };

            return Ok(locationDto);
        }
    }
}
