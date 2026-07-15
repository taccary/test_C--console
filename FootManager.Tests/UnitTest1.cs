using FootManager.Models;

namespace FootManager.Tests;

public class UnitTest1
{
    [Fact]
    public void Creation_Joueur()
    {
        var joueur = new Joueur("Lacazette", 34);

        Assert.Equal("Lacazette", joueur.Nom);
        Assert.Equal(34, joueur.Age);
    }

    [Fact]
    public void Creation_Equipe()
    {
        var equipe = new Equipe("Arsenal");

        Assert.Equal("Arsenal", equipe.Nom);
        Assert.Empty(equipe.Joueurs);
    }

    [Fact]
    public void Affectation_Joueur_Equipe()
    {
        var joueur = new Joueur("Lacazette", 34);
        var equipe = new Equipe("Arsenal");

        equipe.AjouterJoueur(joueur);

        Assert.Contains(joueur, equipe.Joueurs);
    }
}
