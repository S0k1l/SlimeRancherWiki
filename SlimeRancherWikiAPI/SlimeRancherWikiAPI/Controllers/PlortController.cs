using Microsoft.AspNetCore.Mvc;
using SlimeRancherWikiAPI.Dto;
using SlimeRancherWikiAPI.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SlimeRancherWikiAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlortController : ControllerBase
    {
        private readonly IPlortRepository _plortRepository;

        public PlortController(IPlortRepository plortRepository)
        {
            _plortRepository = plortRepository;
        }

        // GET: api/<PlortController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var plorts = await _plortRepository.GetAllPlortsAsync();

            if(plorts == null)  return NotFound();

            var plortsDto = plorts.Select(p => new ItemDto 
            {
                Id = p.Id,
                Name = p.Name,
                ImgUrl = p.ImgUrl,
            })
            .ToList();

            return Ok(plortsDto);
        }

        // GET api/<PlortController>/WithDetails
        [HttpGet("Details")]
        public async Task<IActionResult> Details()
        {
            var plorts = await _plortRepository.GetAllPlortsDetailsAsync();

            if (plorts == null) return NotFound();

            var plortsDto = plorts.Select(p => new PlortDto
            {
                Id = p.Id,
                Name = p.Name,
                ImgUrl = p.ImgUrl,
                MinPrice = p.MinPrice,
                AvgPrice = p.AvgPrice,
                MaxPrice = p.MaxPrice,
                Slime = new()
                {
                    Id = p.Slime.Id,
                    Name = p.Slime.Name,
                    ImgUrl = p.Slime.ImgUrl,
                }
            })
            .ToList();

            return Ok(plortsDto);
        }
    }
}
