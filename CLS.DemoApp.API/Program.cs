using CLS.DemoApp.Application.Contracts.Features;
using CLS.DemoApp.Application.Contracts.Persistence;
using CLS.DemoApp.Application.Services;
using CLS.DemoApp.Infrastructure;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContextPool<CLSAppContext>(options =>
options.UseSqlServer(new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetConnectionString("mycon")  ));


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddScoped<CLSAppContext>();
builder.Services.AddTransient(typeof(IAsyncRepository<>), typeof(AsyncRepository<>));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<IGovernorateAppService, GovernorateAppService>();
builder.Services.AddScoped<ICenterAppService, CenterAppService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
