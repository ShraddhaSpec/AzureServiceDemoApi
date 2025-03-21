var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

string corsDomains = builder.Configuration.GetSection("AppCORS").Value;
string[] domains = corsDomains.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

//builder.Services.AddCors(o => o.AddPolicy("AppCORSPolicy", builder =>
//{
//	builder.AllowAnyOrigin()
//		   .AllowAnyMethod()
//		   .AllowAnyHeader()
//		   .AllowCredentials()
//		   .WithOrigins(domains);
//}));

builder.Services.AddCors(options =>
{
	options.AddPolicy("AllowAll",
		policy => policy.AllowAnyOrigin()
						.AllowAnyMethod()
						.AllowAnyHeader());
});

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

//app.UseCors("AppCORSPolicy");
app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();
