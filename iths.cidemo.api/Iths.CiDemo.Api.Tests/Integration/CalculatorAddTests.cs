using Iths.CiDemo.Api.Tests.Integration.Helpers;

namespace Iths.CiDemo.Api.Tests.Integration;

public class CalculatorAddTests : TestWebApplicationFactory
{
    private readonly HttpClient _client;

    public CalculatorAddTests()
    {
        _client = CreateClient();
    }

    [
        TestCase("1+1", "2"),
        TestCase("1+2", "3"),
        TestCase("1+11", "12"),
        TestCase("1 + 1 + 1", "3")
    ]
    public async Task Calculator_Add_ReturnsCorrectNumber(string values, string expected)
    {
        var response = await _client.PostAsync($"/Add/{values}", null);
        var content = await response.Content.ReadAsStringAsync();
        
        Assert.Multiple(() =>
        {
            Assert.That(response.IsSuccessStatusCode, Is.True);
            Assert.That(content, Is.EqualTo(expected));
        });
    }
}
