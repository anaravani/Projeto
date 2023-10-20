using Microsoft.EntityFrameworkCore;
using Projeto.Context;
using Projeto.Models;
using Projeto.Repositories;
using Projeto.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped(sp => Carrinho.GetCarrinhoCompra(sp));
builder.Services.AddMemoryCache();
builder.Services.AddSession();
builder.Services.AddTransient<IItemRepository, ItemReposittory>();
builder.Services.AddTransient<ICategoriaRepository, CategoriaRepository>();
builder.Services.AddDbContext<AppDbContext>(options => options.
UseSqlite(builder.Configuration.GetConnectionString("DefaulConnection")));
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IHttpContextAccessor,HttpContextAccessor>();

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
app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
name: "categoriaFiltro",
pattern: "Movel/{action}/{categoria?}",
defaults: new { Controller = "Movel", action = "List" }
);

app.MapControllerRoute(
name: "areas",
pattern: "{area:exists}/{controller=Admin}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
