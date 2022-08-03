using CountriesWebAPI.DbContexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
{
    string connectionString = builder.Configuration.GetConnectionString("MainDB");

    builder.Services.AddDbContext<ApplicationDbContext>
    (
        options => options.UseSqlite(connectionString)
    );
    builder.Services.AddControllers();
}

var app = builder.Build();

// Использование страницы для вывода исключений
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapControllers();

app.Run();