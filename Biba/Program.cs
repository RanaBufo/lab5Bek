using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder();

builder.Services.AddCors(); // ��������� ������� CORS

var app = builder.Build();

// ����������� CORS

app.UseCors(builder => builder.WithOrigins("https://localhost:7242").AllowAnyMethod()
                             .WithHeaders("custom-header"));

app.Run(async (context) => await context.Response.WriteAsync("Cats will save the world!!!"));
app.Run();