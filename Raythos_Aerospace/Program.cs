using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Raythos_Aerospace.Areas.Identity.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("Raythos_AerospaceContextConnection") ?? throw new InvalidOperationException("Connection string 'Raythos_AerospaceContextConnection' not found.");

builder.Services.AddDbContext<Raythos_AerospaceContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<Raythos_AerospaceUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<Raythos_AerospaceContext>();

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
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();
app.Run();

