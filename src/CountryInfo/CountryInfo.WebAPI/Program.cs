using CountryInfo.WebAPI.Data;
using CountryInfo.WebAPI.Profiles;
using CountryInfo.WebAPI.Repositories.Abstractions;
using CountryInfo.WebAPI.Repositories.Implementation;
using CountryInfo.WebAPI.Services.Abstractions;
using CountryInfo.WebAPI.Services.Implementation;
using CountryInfo.WebAPI.ValidationStrategies.Implementation;
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

builder.Services.AddSingleton<PhoneCodeValidationStrategy>();
builder.Services.AddAutoMapper(typeof(AppMappingProfile));


builder.Services.AddScoped<ICountryRepository, DefaultCountryRepository>();
builder.Services.AddScoped<IStateRepository, DefaultStateRepository>();
builder.Services.AddScoped<ICityRepository, DefaultCityRepository>();

builder.Services.AddScoped<ICountryService, DefaultCountryService>();
builder.Services.AddScoped<IStateService, DefaultStateService>();
builder.Services.AddScoped<ICityService, DefaultCityService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
