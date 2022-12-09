namespace Iths.CiDemo.Api.Tests;

public class ApiTests
{
    [TestCase("1 + 1", 2)]
    [TestCase("1 + 2", 3)]
    public void Calculator_Add_ReturnsCorrectSum(string input, int expected)
    {
        var calc = new StringCalculator();

        int sum = calc.Add(input);
        
        Assert.That(sum, Is.EqualTo(expected));
    }

    [TestCase("")]
    [TestCase("  ")]
    [TestCase("a")]
    [TestCase("1 1")]
    [TestCase("1 - 1")]
    [TestCase("1 + a")]
    [TestCase("+1")]
    [TestCase(null)]
    public void Calculator_Add_WithInvalidInput_ShouldThrowException(string input)
    {
        var calc = new StringCalculator();

        Assert.Throws<InvalidInputException>(() => calc.Add(input));
    }
}