using Microsoft.AspNetCore.Localization;
using System.Globalization;
using System.Text.Json.Serialization;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<RequestLocalizationOptions>(options =>
{

    var supportedlangs = new[] {
    new CultureInfo("ar"),
    new CultureInfo("en")
    };

    options.DefaultRequestCulture = new Microsoft.AspNetCore.Localization.RequestCulture("ar");
    options.SupportedCultures = supportedlangs;
    options.SupportedUICultures = supportedlangs;

    options.RequestCultureProviders = new List<IRequestCultureProvider>
        {
            new QueryStringRequestCultureProvider(),
            new CookieRequestCultureProvider()
        };
});

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
app.UseRequestLocalization();
app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
