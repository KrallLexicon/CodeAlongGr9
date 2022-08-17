var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(1);
});

var app = builder.Build();

app.UseSession();
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "test",
    pattern: "test",
    defaults: new { controller = "Home", action = "Test" });

app.MapControllerRoute(
    name: "agecheck",
    pattern: "checkage",
    defaults: new { controller = "Check", action = "CheckAge" });

app.Run();
