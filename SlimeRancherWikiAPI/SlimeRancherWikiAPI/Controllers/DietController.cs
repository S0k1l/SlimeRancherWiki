using Microsoft.AspNetCore.Mvc;
using SlimeRancherWikiAPI.Dto;
using SlimeRancherWikiAPI.Interfaces;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SlimeRancherWikiAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DietController : ControllerBase
    {
        private readonly IDietRepository _dietRepository;

        public DietController(IDietRepository dietRepository)
        {
            _dietRepository = dietRepository;
        }

        // GET: api/<DietController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var fruitDiet = await _dietRepository.GetFruitDiet();
            var veggieDiet = await _dietRepository.GetViggieDiet();
            var meatDiet = await _dietRepository.GetMeatDiet();

            if (fruitDiet == null || veggieDiet == null || meatDiet == null) return NotFound();

            var foodDto = new List<DietDto>()
            {
                new DietDto
                {
                    Id = fruitDiet.Id,
                    Name = fruitDiet.Name,
                    ImgUrl = fruitDiet.ImgUrl,
                    Food = fruitDiet.Foods
                        .Select(f => new ItemDto
                        {
                            Id = f.Id,
                            Name = f.Name,
                            ImgUrl = f.ImgUrl,
                        })
                        .ToList(),
                },
                new DietDto
                {
                    Id = veggieDiet.Id,
                    Name = veggieDiet.Name,
                    ImgUrl = veggieDiet.ImgUrl,
                    Food = veggieDiet.Foods
                        .Select(f => new ItemDto
                        {
                            Id = f.Id,
                            Name = f.Name,
                            ImgUrl = f.ImgUrl,
                        })
                        .ToList(),
                },
                new DietDto
                {
                    Id = meatDiet.Id,
                    Name = meatDiet.Name,
                    ImgUrl = meatDiet.ImgUrl,
                    Food = meatDiet.Foods
                        .Select(f => new ItemDto
                        {
                            Id = f.Id,
                            Name = f.Name,
                            ImgUrl = f.ImgUrl,
                        })
                        .ToList(),
                },
            };

            return Ok(foodDto);
        }
    }
}