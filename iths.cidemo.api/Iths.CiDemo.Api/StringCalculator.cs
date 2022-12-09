using System.Text.RegularExpressions;

namespace Iths.CiDemo.Api;

public class StringCalculator
{
    public int Add(string values)
    {
        //REVIEW: Use Guard instead
        if (string.IsNullOrWhiteSpace(values))
            throw new InvalidInputException(values);

        if (!Regex.IsMatch(values, @"\d+\s*\+\s*\d+"))
            throw new InvalidInputException(values);

        return values.Split('+')
            .Select(int.Parse)
            .Sum();
    }
}