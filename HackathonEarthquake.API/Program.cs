using System.Reflection;
using HackathonEarthquake.Core.Repositories;
using HackathonEarthquake.Core.Services;
using HackathonEarthquake.Repository.Context;
using HackathonEarthquake.Repository.Repositories;
using HackathonEarthquake.Service.Mapping;
using HackathonEarthquake.Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(MapProfile));

builder.Services.AddDbContext<EarthquakeDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MsSqlConnection"));
});

builder.Services.AddScoped<ICityRepository, CityRepository>();
builder.Services.AddScoped<ICityService, CityService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
