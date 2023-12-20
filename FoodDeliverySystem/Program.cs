using FoodDeliverySystem.Database;
using FoodDeliverySystem.Repositories;
using FoodDeliverySystem.Repositories.Interfaces;
using FoodDeliverySystem.Services;
using FoodDeliverySystem.Services.Interfaces;
using FoodDeliverySystem.UnitOfWork;
using FoodDeliverySystem.UnitOfWork.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<FoodDeliveryDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("FoodDeliveryDbContext") ?? throw new InvalidOperationException("Connection string 'FoodDeliveryDbContext' not found."));
});
builder.Services.AddControllers();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<ICustomerRepositoy, CustomerRepository>();
builder.Services.AddScoped<IRestaurantRepository, RestaurantRepository>();
builder.Services.AddScoped<IDeliveryDriverRepository, DeliveryDriverRepositoy>();
builder.Services.AddScoped<IMenuItemRepository, MenuItemRepository>();
builder.Services.AddScoped<IOrderRespository, OrderRepository>();
builder.Services.AddScoped<IRestaurant, RestaurantServiceImpl>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

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
