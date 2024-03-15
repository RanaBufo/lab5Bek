using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder();

builder.Services.AddCors(); // добавляем сервисы CORS

var app = builder.Build();

// настраиваем CORS

app.UseCors(builder => builder.WithOrigins("https://localhost:7242").AllowAnyMethod()
                             .WithHeaders("custom-header"));

app.Run(async (context) => await context.Response.WriteAsync("Cats will save the world!!!"));
app.Run();