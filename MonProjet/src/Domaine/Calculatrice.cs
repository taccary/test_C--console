namespace Domaine;

/// <summary>Fournit des opérations arithmétiques simples.</summary>
public class Calculatrice
{
    public int Additionner(int a, int b) => a + b;
    public int Soustraire(int a, int b) => a - b;
    public int Multiplier(int a, int b) => a * b;

    /// <exception cref="DivideByZeroException">Lancée si b vaut zéro.</exception>
    public double Diviser(int a, int b)
    {
        if (b == 0)
            throw new DivideByZeroException("La division par zéro est interdite.");
        return (double)a / b;
    }
}
