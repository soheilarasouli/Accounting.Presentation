using Accounting.Application.AccountGroups.Queries.Find;
using Accounting.Domain.AccountGroups.Contracts;
using Accounting.Infrastructure.Data.AccountGroups;
using Accounting.Infrastructure.Data.Persistence.Context;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") 
    ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found!");

// Register services
builder.Services.AddScoped<IAccountGroupQueryRepository, AccountGroupQueryRepository>();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(FindAccountGroupQuery).Assembly));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AccountingDbContext>(options =>
    options.UseSqlServer(connectionString, x => x.MigrationsAssembly("Accounting.Infrastructure.Data")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
