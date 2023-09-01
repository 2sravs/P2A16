using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApplication16.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<WebApplication16DbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebApplication16DbContext") ?? throw new InvalidOperationException("Connection string 'WebApplication16DbContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Tasks}/{action=Index}/{id?}");

app.Run();
