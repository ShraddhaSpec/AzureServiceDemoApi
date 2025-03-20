var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

string corsDomains = builder.Configuration.GetSection("AppCORS").Value;
string[] domains = corsDomains.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

builder.Services.AddCors(o => o.AddPolicy("AppCORSPolicy", builder =>
{
	builder.AllowAnyOrigin()
		   .AllowAnyMethod()
		   .AllowAnyHeader()
		   .AllowCredentials()
		   .WithOrigins(domains);
}));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseCors("AppCORSPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
