using Microsoft.AspNetCore.Mvc;
using SlimeRancherWikiAPI.Dto;
using SlimeRancherWikiAPI.Interfaces;
using SlimeRancherWikiAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SlimeRancherWikiAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlimeController : ControllerBase
    {
        private readonly ISlimeRepository _slimeRepository;

        public SlimeController(ISlimeRepository slimeRepository)
        {
            _slimeRepository = slimeRepository;
        }

        // GET: api/<SlimeController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var slimes = await _slimeRepository.GetAllSlimesAsync();

            if (slimes == null) { return NotFound(); }

            var SlimesDto = slimes.Select(s => new ItemDto { Id =s.Id,Name = s.Name, ImgUrl = s.ImgUrl }).ToList();

            return Ok(SlimesDto.OrderBy(s => s.Name));
        }

        // GET api/<SlimeController>/1
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if(!ModelState.IsValid) { return BadRequest(); }

            if(id < 0) { return BadRequest("Invalid ID"); }

            var slime = await _slimeRepository.GetSlimeAsync(id);

            if (slime == null) { return NotFound(); }

            var slimeDto = new SlimeDto
            {
                Id = slime.Id,
                Name = slime.Name,
                ImgUrl = slime.ImgUrl,
                Toy = slime.Toy == null ? null : new() 
                { 
                    Id = slime.Toy.Id, 
                    Name = slime.Toy.Name, 
                    ImgUrl = slime.Toy.ImgUrl 
                },
                Locations = slime.SlimeLocation
                    .Select(sl => new ItemDto 
                    { 
                        Id = sl.Location.Id, 
                        Name = sl.Location.Name, 
                        ImgUrl = sl.Location.ImgUrl
                    })
                    .ToList(),
                Diet = slime.Diet == null ? null : new() 
                { 
                    Id = slime.Diet.Id, 
                    Name = slime.Diet.Name, 
                    ImgUrl = slime.Diet.ImgUrl 
                },
                FavFood = slime.FavFood == null ? null : new() 
                { 
                    Id = slime.FavFood.Id, 
                    Name = slime.FavFood.Name, 
                    ImgUrl = slime.FavFood.ImgUrl 
                },
                Plort = slime.Plort == null ? null : new () 
                { 
                    Id = slime.Plort.Id, 
                    Name = slime.Plort.Name, 
                    ImgUrl = slime.Plort.ImgUrl 
                },
            };

            return Ok(slimeDto);
        }
    }
}
