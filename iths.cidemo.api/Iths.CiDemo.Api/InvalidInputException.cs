namespace Iths.CiDemo.Api;

public class InvalidInputException : Exception
{
    public InvalidInputException(string input)
        : base($"The provided input was malformed: {input}")
    {
    }
}
