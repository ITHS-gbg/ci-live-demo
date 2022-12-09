using Iths.CiDemo.Api;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<StringCalculator>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/add/{values}", (StringCalculator calc, string values) 
    => calc.Add(values));

app.Run();