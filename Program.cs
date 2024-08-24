
using Microsoft.EntityFrameworkCore;
using SerialKeyGenerate;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    // Get the database connection string from appsettings.json
    IConfiguration configuration = builder.Configuration;
    var connectionString = configuration.GetConnectionString("DefaultConnection");

    // Configure DbContext to use MySql or other database provider
    options.UseMySQL(connectionString!); // Example for MySql
});

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
