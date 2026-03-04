using UniBet.Interfaces.IServices;
using UniBet.Interfaces.IRepositories;
using UniBet.Services;
using UniBet.Repositories;
using System.Globalization;
using Microsoft.EntityFrameworkCore;
using UniBet.Data.Contexts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

string mySqlConnection = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<AppDbContext>(
    options => options.UseMySql(mySqlConnection, ServerVersion.AutoDetect(mySqlConnection)));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
