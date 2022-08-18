using AspStore.ShopUi.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
var connectionString = builder.Configuration.GetConnectionString("StoreCnn");

builder.Services.AddDbContext<StoreDbContext>(options=>options.UseSqlServer(connectionString));

builder.Services.AddScoped<IProductRepository, EfProductRepository>();

var app = builder.Build();

app.UseDeveloperExceptionPage();

app.UseStatusCodePages();

app.UseStaticFiles();

app.UseRouting();

app.UseEndpoints(
    endpoint => 
    endpoint.MapDefaultControllerRoute());

app.Run();
