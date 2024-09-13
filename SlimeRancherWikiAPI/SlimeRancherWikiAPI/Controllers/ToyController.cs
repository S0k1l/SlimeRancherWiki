using Microsoft.AspNetCore.Mvc;
using SlimeRancherWikiAPI.Dto;
using SlimeRancherWikiAPI.Interfaces;
using SlimeRancherWikiAPI.Models;

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
        [HttpGet("Details")]
        public async Task<IActionResult> Details()
        {
            var toy = await _toyRepository.GetAllToysDetailsAsync();

            if(toy == null) return NotFound();

            var toyDto = toy.Select(t => new ToyDto
                {
                    Id = t.Id,
                    Name = t.Name,
                    ImgUrl = t.ImgUrl,
                    Price = t.Price,
                    Slime = new ItemDto { Id = t.Slime.Id, ImgUrl = t.Slime.ImgUrl, Name = t.Slime.Name },
                })
                .ToList();

            return Ok(toyDto);
        }
    }
}
