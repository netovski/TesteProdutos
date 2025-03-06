using Microsoft.EntityFrameworkCore;
using ProdutoApp.Data;
using ProdutoApp.Models;

var builder = WebApplication.CreateBuilder(args);

// Configura o banco de dados SQLite usando o Entity Framework Core
builder.Services.AddDbContext<ProdutoContext>(options =>
    options.UseSqlite("Data Source=produtos.db"));

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

// Roteamento MVC
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Produto}/{action=Index}/{id?}");

app.Run();

