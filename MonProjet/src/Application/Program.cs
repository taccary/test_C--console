using Domaine;

var calc = new Calculatrice();

Console.WriteLine("=== Calculatrice BTS SIO ===");
Console.WriteLine($"5 + 3 = {calc.Additionner(5, 3)}");
Console.WriteLine($"10 - 4 = {calc.Soustraire(10, 4)}");
Console.WriteLine($"6 × 7 = {calc.Multiplier(6, 7)}");
Console.WriteLine($"15 / 4 = {calc.Diviser(15, 4)}");

try
{
    calc.Diviser(1, 0);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Erreur : {ex.Message}");
}
