using Microsoft.AspNetCore.Mvc;

namespace CountryInfo.WebAPI.Extensions
{
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
