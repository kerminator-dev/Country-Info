using CountriesWebAPI.DbContexts;
using CountriesWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CountriesWebAPI.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class CountriesController : BaseDbContextController
    {
        public CountriesController(ApplicationDbContext context) : base(context)
        {

        }

        [HttpGet("All")]
        public async Task<List<Country>> GetAll()
        {
            return await _dbContext.Countries.ToListAsync();
        }

        /// <summary>
        /// Получить данные о стране
        /// </summary>
        /// <param name="countryId"></param>
        /// <returns></returns>
        [HttpGet("Detail/{id}")]
        public async Task<IActionResult> GetDetail(int countryId)
        {
            // EF оптимизирует запрос и ищет сначала нужную страну и
            // только потом связывает данные States по ключу Country.Id
            var searchResult = await _dbContext.Countries.Include(c => c.States).FirstOrDefaultAsync(c => c.Id == countryId); 

            if (searchResult == null)
            {
                return NotFound();
            }

            return Ok(searchResult);
        }

        [HttpGet("Count")]
        public async Task<IActionResult> GetCount()
        {
            return Ok(await _dbContext.Countries.CountAsync());
        }

        [HttpGet("PhoneCode/{phoneCode}")]
        public IActionResult GetCountryByPhoneCode(int phoneCode)
        {
            var countries = _dbContext.Countries.Where(c => c.PhoneCode == phoneCode);

            if (countries == null)
                return NotFound();

            return Ok(countries);
        }
    }
}