using Microsoft.AspNetCore.Mvc;
using SlimeRancherWikiAPI.Dto;
using SlimeRancherWikiAPI.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SlimeRancherWikiAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private readonly IFoodRepository _foodRepository;

        public FoodController(IFoodRepository foodRepository)
        {
            _foodRepository = foodRepository;
        }

        // GET: api/<FoodController>/Fruits
        [HttpGet("Fruits")]
        public async Task<IActionResult> GetFruits()
        {
            var fruits = await _foodRepository.GetFruits();

            if(fruits == null) return NotFound();

            var fruitDto = fruits.Select(f => new ItemDto {
                Id = f.Id, 
                ImgUrl = f.ImgUrl, 
                Name = f.Name, 
            })
                .ToList();

            return Ok(fruitDto);
        }

        // GET: api/<FoodController>/Veggies
        [HttpGet("Veggies")]
        public async Task<IActionResult> GetVeggies()
        {
            var veggies = await _foodRepository.GetVeggies();

            if (veggies == null) return NotFound();

            var veggiesDto = veggies.Select(f => new ItemDto
            {
                Id = f.Id,
                ImgUrl = f.ImgUrl,
                Name = f.Name,
            })
                .ToList();

            return Ok(veggiesDto);
        }

        // GET: api/<FoodController>/Meats
        [HttpGet("Meats")]
        public async Task<IActionResult> GetMeats()
        {
            var meats = await _foodRepository.GetMeats();

            if (meats == null) return NotFound();

            var meatsDto = meats.Select(f => new ItemDto
            {
                Id = f.Id,
                ImgUrl = f.ImgUrl,
                Name = f.Name,
            })
                .ToList();

            return Ok(meatsDto);
        }

        // GET api/<FoodController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);

            if (id <= 0) return BadRequest("Invalad Id");

            var food = await _foodRepository.GetFoodDetails(id);

            if (food == null) return NotFound();

            var locations = food.FoodLocation
                .Select(fl => new ItemDto 
                { 
                    Id = fl.Location.Id, 
                    Name = fl.Location.Name, 
                    ImgUrl = 
                    fl.Location.ImgUrl
                })
                .ToList();
            locations = locations.Any() ? locations : null;

            var foodDto = new FoodDto
            {
                Id = food.Id,
                Name = food.Name,
                ImgUrl = food.ImgUrl,
                Locations = locations,
                Slime = food.Slime == null ? null : new()
                {
                    Id = food.Slime.Id,
                    ImgUrl = food.Slime.ImgUrl,
                    Name = food.Slime.Name
                },
                Diet = food.Diet == null ? null : new()
                {
                    Id = food.Diet.Id,
                    ImgUrl = food.Diet.ImgUrl,
                    Name = food.Diet.Name
                },
            };

            return Ok(foodDto);
        }
    }
}
