namespace FootManager.Models;

public class Joueur
{
    public string Nom { get; set; }
    public int Age { get; set; }

    public Joueur(string nom, int age)
    {
        Nom = nom;
        Age = age;
    }

    public override string ToString()
    {
        return $"{Nom} ({Age} ans)";
    }
}