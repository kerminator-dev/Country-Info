using CountriesWebAPI.DbContexts;
using CountriesWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CountriesWebAPI.Controllers
{
    [Route("[controller]")]
    public class StatesController : BaseDbContextController
    {
        public StatesController(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        [HttpGet("All")]
        public async Task<List<State>> GetAll()
        {
            return await _dbContext.States.ToListAsync();
        }

        [HttpGet("Detail/{stateId}")]
        public async Task<IActionResult> GetDetail(int stateId)
        {
            // EF оптимизирует запрос и ищет сначала нужный регион и
            // только потом связывает данные Cities по ключу State.Id
            var searchResult = await _dbContext.States.Include(s => s.Cities).FirstOrDefaultAsync(s => s.Id == stateId);

            if (searchResult == null)
                return NotFound();

            return Ok(searchResult);
        }

        [HttpGet("Count")]
        public async Task<IActionResult> GetCount()
        {
            return Ok(await _dbContext.States.CountAsync());
        }
    }
}
