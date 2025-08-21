using ArmoryDisplayBE.Data;
using ArmoryDisplayBE.Services.Constellation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

#region Services
builder.Services.AddScoped<IConstellationService, ConstellationService>();
#endregion
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>();
builder.Services.AddCors(options =>
    options.AddPolicy(
        name: "ArthenaArmoryDisplay",
        policy =>
        {
            policy.WithOrigins("http://localhost:5167").AllowAnyMethod().AllowAnyHeader();
        }
    )
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.Run();
