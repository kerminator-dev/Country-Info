using CountryInfoAPI.DbContexts;
using CountryInfoAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CountryInfoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : BaseController
    {
        public CountriesController(ApplicationDbContext dbContext)
            : base(dbContext) { }

        /// <summary>
        /// Получить список всех стран
        /// </summary>
        /// <returns></returns>
        [HttpGet("All")]
        public override async Task<IActionResult> GetAllAsync()
        {
            var countries = await _dbContext.Countries.ToListAsync();

            if (countries == null)
                return NotFound();

            return Ok(countries);
        }

        /// <summary>
        /// Получить данные о стране включая данные о регионах страны
        /// </summary>
        /// <param name="countryId"></param>
        /// <returns></returns>
        [HttpGet("Detail/{countryId}")]
        public override async Task<IActionResult> GetDetailAsync(int countryId)
        {
            var searchResult = await _dbContext.Countries.Include(c => c.States).FirstOrDefaultAsync(c => c.Id == countryId);

            if (searchResult == null)
                return NotFound();

            return Ok(searchResult);
        }

        /// <summary>
        /// Получить общее количество стран
        /// </summary>
        /// <returns></returns>
        [HttpGet("Count")]
        public override async Task<IActionResult> GetCountAsync()
        {
            return Ok(await _dbContext.Countries.CountAsync());
        }

        /// <summary>
        /// Получить список стран по коду телефона
        /// </summary>
        /// <param name="phoneCode"></param>
        /// <returns></returns>
        [HttpGet("PhoneCode/{phoneCode}")]
        public async Task<IActionResult> GetCountriesByPhoneCodeAsync(int phoneCode)
        {
            var countries = await _dbContext.Countries.Where(c => c.PhoneCode == phoneCode).ToListAsync();

            if (countries == null)
                return NotFound();

            return Ok(countries);
        }
    }
}
