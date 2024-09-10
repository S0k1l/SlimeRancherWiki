using Microsoft.AspNetCore.Mvc;
using SlimeRancherWikiAPI.Dto;
using SlimeRancherWikiAPI.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SlimeRancherWikiAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToyController : ControllerBase
    {
        private readonly IToyRepository _toyRepository;

        public ToyController(IToyRepository toyRepository)
        {
            _toyRepository = toyRepository;
        }

        // GET: api/<ToyController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var toys = await _toyRepository.GetAllToysAsync();

            if(toys == null) return NotFound();

            var toysDto = toys.Select(t => new ItemDto
            {
                Id = t.Id,
                Name = t.Name,
                ImgUrl = t.ImgUrl,
            })
            .ToList();
            return Ok(toysDto.OrderBy(t => t.Name));
        }

        // GET api/<ToyController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);

            if(id <= 0) return BadRequest("Invalid Id");

            var toy = await _toyRepository.GetToyAsync(id);

            if(toy == null) return NotFound();

            var toyDto = new ToyDto
            {
                Id = toy.Id,
                Name = toy.Name,
                ImgUrl = toy.ImgUrl,
                Price = toy.Price,
                Slime = new ItemDto { Id = toy.Slime.Id, ImgUrl = toy.Slime.ImgUrl, Name = toy.Slime.Name },
            };

            return Ok(toyDto);
        }
    }
}
