using Calculator.API.Services;
using Xunit;

namespace Calculator.Tests;

public class CalculatorServiceTests
{
    private readonly CalculatorService _service = new();

    [Fact]
    public void Add_TwoPositiveNumbers_ReturnsSum()
    {
        double a = 2;
        double b = 3;

        var result = _service.Add(a, b);

        Assert.Equal(5, result);
    }

    [Fact]
    public void Subtract_TwoNumbers_ReturnsDifference()
    {
        double a = 10;
        double b = 4;

        var result = _service.Subtract(a, b);

        Assert.Equal(6, result);
    }

    [Fact]
    public void Multiply_TwoNumbers_ReturnsProduct()
    {
        double a = 3;
        double b = 4;

        var result = _service.Multiply(a, b);

        Assert.Equal(12, result);
    }

    [Fact]
    public void Divide_TwoNumbers_ReturnsQuotient()
    {
        double a = 12;
        double b = 4;

        var result = _service.Divide(a, b);

        Assert.Equal(3, result);
    }

    [Fact]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        double a = 10;
        double b = 0;

        Assert.Throws<DivideByZeroException>(() => _service.Divide(a, b));
    }
}

