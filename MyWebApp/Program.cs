var builder = WebApplication.CreateBuilder(args);

//app.MapGet("/", () => "Hello World!");
builder.Services.AddControllersWithViews();
var app = builder.Build();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Student}/{action=Index}/{id?}"
);
app.Run();
