namespace FootManager.Models;

public class Equipe
{
    public string Nom { get; set; }

    public List<Joueur> Joueurs { get; } = new();

    public Equipe(string nom)
    {
        Nom = nom;
    }

    public void AjouterJoueur(Joueur joueur)
    {
        Joueurs.Add(joueur);
    }
}