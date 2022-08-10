using CountryInfoAPI.DbContexts;
using CountryInfoAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CountryInfoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatesController : BaseController
    {
        public StatesController(ApplicationDbContext dbContext)
            : base(dbContext) { }


        /// <summary>
        /// Получить список всех регионов
        /// </summary>
        /// <returns></returns>
        [HttpGet("All")]
        public override async Task<IActionResult> GetAllAsync()
        {
            var states = await _dbContext.States.ToListAsync();

            if (states == null)
                return NotFound();

            return Ok(states);
        }

        /// <summary>
        /// Получить данные о регионе включая города региона
        /// </summary>
        /// <param name="stateId"></param>
        /// <returns></returns>
        [HttpGet("Detail/{stateId}")]
        public override async Task<IActionResult> GetDetailAsync(int stateId)
        {
            var searchResult = await _dbContext.States.Include(s => s.Cities).FirstOrDefaultAsync(s => s.Id == stateId);

            if (searchResult == null)
                return NotFound();

            return Ok(searchResult);
        }

        /// <summary>
        /// Получить общее количество регионов
        /// </summary>
        /// <returns></returns>
        [HttpGet("Count")]
        public override async Task<IActionResult> GetCountAsync()
        {
            return Ok(await _dbContext.States.CountAsync());
        }
    }
}
