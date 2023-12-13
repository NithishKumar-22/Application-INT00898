// Project Title : Pick and Drop
// Author        : Nithish Kumar R
// Created at    : Feb 20
// Last Modified : July 24
// Reviewed at   : March 15
// Reviewed by   : Anitha Manogaran

using Microsoft.EntityFrameworkCore;
using Application.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();      
builder.Services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("User")));
builder.Services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("Admin")));
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(
    options =>
    {
        options.Cookie.HttpOnly = true;
        options.Cookie.IsEssential=true;
    }
);  
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
