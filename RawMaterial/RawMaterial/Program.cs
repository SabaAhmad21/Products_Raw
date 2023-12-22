using Microsoft.EntityFrameworkCore;
using RawMaterial.Infrastructure.Implementation;
using RawMaterial.Infrastructure.Interface;
using RawMaterial.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ProductDbContext>(x => x.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=ProductDB;Trusted_Connection=True;"));
builder.Services.AddTransient<IMaterialRepository,MaterialRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
