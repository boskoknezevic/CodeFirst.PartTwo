using CodeFirst.PartTwo;
using CodeFirst.PartTwo.Interfaces;
using CodeFirst.PartTwo.Models;
using CodeFirst.PartTwo.Repository;
using CodeFirst.Services.Interfaces;
using CodeFirst.Services.Models;
using CodeFirst.Services.Services;
using CodeFirst.Services.Validator;
using CodeFirst.WebApi.Models;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddScoped<ICarServices, CarServices>();
builder.Services.AddScoped<ICarRepository, CarRepository>();

builder.Services.AddScoped<IEngineServices, EngineServices>();
builder.Services.AddScoped<IEngineRepository, EngineRepository>();

builder.Services.AddScoped<IEngineTypeServices, EngineTypeServices>();
builder.Services.AddScoped<IEngineTypeRepository, EngineTypeRepository>();

builder.Services.AddScoped<IValidator<CodeFirst.Services.Models.Car>, CarValidator>();

builder.Services.AddDbContext<CarContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



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
