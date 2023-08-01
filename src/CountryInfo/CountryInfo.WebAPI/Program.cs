using CountryInfo.WebAPI.Data;
using CountryInfo.WebAPI.Repositories.Abstractions;
using CountryInfo.WebAPI.Repositories.Implementation;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>
(
    options =>
    {
        string connectionString = builder.Configuration.GetConnectionString("MainDB");
        options.UseSqlite(connectionString);
    }
);
builder.Services.AddScoped<ICountryRepository, DefaultCountryRepository>();
builder.Services.AddScoped<IStateRepository, DefaultStateRepository>();
builder.Services.AddScoped<ICityRepository, DefaultCityRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// app.UseAuthorization();

app.MapControllers();

app.Run();
