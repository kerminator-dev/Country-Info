using CountriesWebAPI.DbContexts;
using Microsoft.AspNetCore.Mvc;

namespace CountriesWebAPI.Controllers
{
    /// <summary>
    /// Base-Controller с контекстом данных ApplicationDbContext
    /// </summary>
    public abstract class BaseDbContextController : Controller
    {
        protected readonly ApplicationDbContext _dbContext;

        public BaseDbContextController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
