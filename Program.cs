using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using VamBlazor.Client.Data;
using Microsoft.Extensions.DependencyInjection;
using DAL;
using Serilog;
using VamBlazor.Client.Application.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMudServices();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Information()
    .WriteTo.File("logs/VamApp.log", rollingInterval: RollingInterval.Day) // لاگ‌ها در فایل
    .CreateLogger();

// اضافه کردن Serilog به سیستم لاگینگ ASP.NET Core
builder.Host.UseSerilog();
builder.Services.AddScoped<PersonServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
