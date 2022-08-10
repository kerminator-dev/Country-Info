using CountryInfoAPI.DbContexts;
using CountryInfoAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CountryInfoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : BaseController
    {
        public CitiesController(ApplicationDbContext dbContext)
            : base(dbContext) { }

        /// <summary>
        /// Получить список всех городов
        /// </summary>
        /// <returns></returns>
        [HttpGet("All")]
        public override async Task<IActionResult> GetAllAsync()
        {
            var cities = await _dbContext.Cities.ToListAsync();

            if (cities == null)
                return NotFound();

            return Ok(cities);
        }

        /// <summary>
        /// Получить данные о городе
        /// </summary>
        /// <param name="cityId"></param>
        /// <returns></returns>
        [HttpGet("Detail/{cityId}")]
        public override async Task<IActionResult> GetDetailAsync(int cityId)
        {
            var city = await _dbContext.Cities.FirstOrDefaultAsync(c => c.Id == cityId);

            if (city == null)
                return NotFound();

            return Ok(city);
        }

        /// <summary>
        /// Получить общее количество городов
        /// </summary>
        /// <returns></returns>
        [HttpGet("Count")]
        public override async Task<IActionResult> GetCountAsync()
        {
            return Ok(await _dbContext.Cities.CountAsync());
        }
    }
}
