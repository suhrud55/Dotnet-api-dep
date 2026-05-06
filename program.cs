using MyEnterpriseApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Logging
builder.Logging.ClearProviders();
builder.Logging.AddConsole();

// Dependency Injection (enterprise style)
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IMessageService, MessageService>();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
