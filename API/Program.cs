using API.Data;
using API.DTOs;
using API.Entities;
using Ganss.Xss;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var services = builder.Services;

services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer("Data Source=DESKTOP-D5KVGO3;Initial Catalog=vuedotnet;Integrated Security=True;TrustServerCertificate=True");
});

services.AddAutoMapper(mapper =>
{
    mapper.CreateMap<Review, ReviewDto>().ReverseMap();
});

services.AddScoped<HtmlSanitizer>();

services.AddControllers();
services.AddCors();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();
services.Configure<RouteOptions>(options =>
{
    options.LowercaseUrls = true;
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(policy => policy
    .AllowAnyHeader()
    .AllowAnyMethod()
    .WithOrigins("http://localhost:8081")
);

app.UseAuthorization();

app.MapControllers();


app.Run();
