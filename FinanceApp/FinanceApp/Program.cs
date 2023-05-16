using FinanceApp.DataAccess;
using FinanceApp.DataAccess.Entities;
using FinanceApp.Services.Api.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using MediatR;
using FinanceApp.Services.Mappings;
using FinanceApp.DataAccess.CQRS;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<HomeBudgetStorageContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("HomeBudgetDataBaseConnection")));
builder.Services.AddMediatR(typeof(ResponseBase<>));
builder.Services.AddAutoMapper(typeof(GetMoneyProfile).Assembly);
builder.Services.AddAutoMapper(typeof(AddMoneyProfile).Assembly);
builder.Services.AddTransient<IQueryExecutor, QueryExecutor>();
builder.Services.AddTransient<ICommandExecutor, CommandExecutor>();

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
