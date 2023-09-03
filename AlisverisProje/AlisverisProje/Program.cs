using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using AlisverisProje.Data;
using AlisverisProje.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("AlisverisContextConnection") ?? throw new InvalidOperationException("Connection string 'AlisverisContextConnection' not found.");

builder.Services.AddDbContext<AlisverisContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<AlisverisProjeUser>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<AlisverisContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireUppercase = true;
});

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
