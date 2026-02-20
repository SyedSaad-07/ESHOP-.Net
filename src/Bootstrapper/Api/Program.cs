//using Microsoft.AspNetCore.DataProtection.Repositories;
using Catalog;
using Basket;
using Ordering;
var builder = WebApplication.CreateBuilder(args);

// Register custom services
builder.Services.AddCatalogModule(builder.Configuration);
builder.Services.AddBasketModule(builder.Configuration);
builder.Services.AddOrderingModule(builder.Configuration);

//builder.Services.AddTransient<IMyService, MyService>();
//builder.Services.AddScoped<IMyRepository, MyRepository>();
//builder.Services.AddSingleton<IConfiguration>(builder.Configuration);
var app = builder.Build();

// Configure the HTTP request pipeline
app.Run();
