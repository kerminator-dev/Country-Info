using CountryInfoAPI.DbContexts;
using Microsoft.AspNetCore.Mvc;

namespace CountryInfoAPI.Controllers
{
    public abstract class BaseController : Controller
    {
        protected readonly ApplicationDbContext _dbContext;

        public BaseController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public abstract Task<IActionResult> GetAllAsync();

        public abstract Task<IActionResult> GetDetailAsync(int id);

        public abstract Task<IActionResult> GetCountAsync();
    }
}
