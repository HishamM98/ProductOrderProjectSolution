using Microsoft.EntityFrameworkCore;
using PracticeProject.Core.Domain.RepositoryContracts;
using PracticeProject.Core.ServiceContracts;
using PracticeProject.Core.Services;
using PracticeProject.Infrastructure.DbContext;
using PracticeProject.Infrastructure.Repositories;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IProductsRepository, ProductsRepository>();
//builder.Services.AddScoped<IOrdersRepository, OrderRepository>();
//builder.Services.AddScoped<IOrderItemsRepository, OrderItemRepository>();

builder.Services.AddScoped<IProductsService, ProductsService>();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});

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
