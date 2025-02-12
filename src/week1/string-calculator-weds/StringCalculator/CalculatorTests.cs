

namespace StringCalculator;
public class CalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new Calculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("1", 1)]
    [InlineData("2", 2)]
    [InlineData("3256", 3256)]
    [InlineData("-42", -42)]
    public void SingleDigit(string numbers, int expected)
    {
        var calculator = new Calculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1,2", 3)]
    [InlineData("3,4", 7)]
    [InlineData("328,239", 567)]
    [InlineData("-42,15", -27)]
    [InlineData("-12,-4", -16)]
    public void TwoDigits(string numbers, int expected)
    {
        var calculator = new Calculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1,2,3", 6)]
    [InlineData("3,4,5,6,7,8", 33)]
    [InlineData("328,239,4,-3,20,-17", 571)]
    [InlineData("-42,15,-3", -30)]
    [InlineData("-12,-4,-8", -24)]
    public void MoreThanTwoDigits(string numbers, int expected)
    {
        var calculator = new Calculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1,2\n3", 6)]
    public void TwoDelimiters(string numbers, int expected)
    {
        var calculator = new Calculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }
}
