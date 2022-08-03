using CountriesWebAPI.DbContexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CountriesWebAPI.Controllers
{
    [Route("[controller]")]
    public class CitiesController : BaseDbContextController
    {
        public CitiesController(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        [HttpGet("All")]
        public IActionResult GetAll()
        {
            return Ok(_dbContext.Cities);
        }

        [HttpGet("Detail/{cityId}")]
        public async Task<IActionResult> GetDetail(int cityId)
        {
            var city = await _dbContext.Cities.FirstOrDefaultAsync(c => c.Id == cityId);

            if (city == null)
                return NotFound();

            return Ok(city);
        }
    }
}
