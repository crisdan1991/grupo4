using PrjVehiculos.Models;
using Microsoft.EntityFrameworkCore;
using PrjVehiculos.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//Agregar: Sql Connection
builder.Services.AddDbContext<VehiculosContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexionSql"), options => options.CommandTimeout(120));
});

//services cors
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();

//app cors
app.UseCors("corsapp");

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
