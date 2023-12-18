using Microsoft.AspNetCore.Identity;
using RWG.Context;
using RWG.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DatabaseContext>();
builder.Services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<DatabaseContext>().AddDefaultTokenProviders();
// Register the SeedExtension as a scoped service in the dependency injection container
builder.Services.AddScoped<SeedExtension>();




// Build the application
var app = builder.Build();
// Create a scope within the application services to resolve dependencies
using var scope = app.Services.CreateScope();
// Retrieve the SeedExtension service from the service provider
var seeder = scope.ServiceProvider.GetService<SeedExtension>();
// Ensure that the SeedExtension service is not null before attempting to use it
// Seed the database asynchronously by calling the SeedAsync method
await seeder!.SeedAsync();



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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
