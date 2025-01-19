using MongoDB.Driver;
using UserApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add MongoDB connection
builder.Services.AddSingleton<IMongoClient, MongoClient>(sp =>
    new MongoClient(builder.Configuration.GetValue<string>("MongoSettings:ConnectionString")));

// Add UserService
builder.Services.AddScoped<UserService>();

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();

