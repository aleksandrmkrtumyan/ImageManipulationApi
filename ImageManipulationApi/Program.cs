using Application.Contract.Infrastructure.Effects;
using Application.Contract.Infrastructure.Resizes;
using Infrastructure.Resizes;
using Persistence.Effects;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IImageEffect1, ImageEffect1>();
builder.Services.AddScoped<IImageEffect2, ImageEffect2>();
builder.Services.AddScoped<IImageEffect3, ImageEffect3>();
builder.Services.AddScoped<IImageResize, ImageResize>();

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
