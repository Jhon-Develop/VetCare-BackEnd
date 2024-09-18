using DotNetEnv;
using Microsoft.EntityFrameworkCore;
using VetCare_BackEnd.Data;
using VetCare_BackEnd.Models;
using VetCare_BackEnd.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
Env.Load();
var dbHost = Environment.GetEnvironmentVariable("DB_HOST");
var dbPort = Environment.GetEnvironmentVariable("DB_PORT");
var dbDatabaseName = Environment.GetEnvironmentVariable("DB_DATABASE");
var dbUser = Environment.GetEnvironmentVariable("DB_USERNAME");
var dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD");
var conectionDB = $"server={dbHost};port={dbPort};database={dbDatabaseName};uid={dbUser};password={dbPassword}";
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(conectionDB, ServerVersion.Parse("8.0.20-mysql")));



builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder =>
        {
            builder.WithOrigins("http://192.168.89.167:6969", "http://localhost:3000")
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowCredentials();
        });
});

// builder.Services.AddControllers()
//     .AddJsonOptions(options =>
//     {
//         options.JsonSerializerOptions.Converters.Add(new DateOnlyConverter());
//     });


// For connect to the session storage
builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<JwtHelper>()

builder.Services.AddControllers();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// //para revisar so las solictudes estan llegando
// app.Use(async (context, next) =>
// {
//     Console.WriteLine($"Request received for {context.Request.Path}");
//     await next();
// });

// app.UseHttpsRedirection();

app.UseCors("AllowSpecificOrigin");

app.UseAuthorization();

app.MapControllers();

app.Run();

//mi primer comentario practica