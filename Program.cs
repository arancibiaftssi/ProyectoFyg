using Microsoft.EntityFrameworkCore;
using ProyectoReact.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

//builder.Services.AddDbContext<GyfContext>(opciones => {
//    opciones.UseSqlServer(builder.Configuration.GetConnectionString("cadenaSQL"));
//});

builder.Services.AddDbContext<GyfContext>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

 app.Run();
