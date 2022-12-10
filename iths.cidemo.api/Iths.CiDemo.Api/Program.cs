using Iths.CiDemo.Api;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<StringCalculator>();

var app = builder.Build();

app.MapPost("/add/{values}", (StringCalculator calc, string values)
    => calc.Add(values));

app.Run();

public partial class Program
{
}
