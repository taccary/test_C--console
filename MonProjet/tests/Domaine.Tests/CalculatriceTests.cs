using Domaine;

namespace Domaine.Tests;

public class CalculatriceTests
{
    private readonly Calculatrice _calc = new();

    [Fact]
    public void Additionner_ReturnsCorrectSum()
    {
        Assert.Equal(8, _calc.Additionner(5, 3));
    }

    [Fact]
    public void Soustraire_ReturnsCorrectDifference()
    {
        Assert.Equal(6, _calc.Soustraire(10, 4));
    }

    [Fact]
    public void Multiplier_ReturnsCorrectProduct()
    {
        Assert.Equal(42, _calc.Multiplier(6, 7));
    }

    [Fact]
    public void Diviser_ReturnsCorrectQuotient()
    {
        Assert.Equal(2.5, _calc.Diviser(5, 2));
    }

    [Fact]
    public void Diviser_ByZero_ThrowsDivideByZeroException()
    {
        Assert.Throws<DivideByZeroException>(() => _calc.Diviser(1, 0));
    }
}
