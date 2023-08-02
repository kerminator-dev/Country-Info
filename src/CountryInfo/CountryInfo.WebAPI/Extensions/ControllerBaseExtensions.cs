using Microsoft.AspNetCore.Mvc;

namespace CountryInfo.WebAPI.Extensions
{
    /// <summary>
    /// Это тотальное поражение
    /// 
    /// Создавать Extension-методы для абстрактных классов нельзя
    /// Как оказалось, ControllerBase - абстрактный класс
    /// </summary>
    public static class ControllerBaseExtensions
    {
        public static IActionResult InternalServerError(this ControllerBase controller)
        {
            return controller.StatusCode(500);
        }

        public static IActionResult InternalServerError(this ControllerBase controller, object? value)
        {
            return controller.StatusCode(500, value);
        }
    }
}
