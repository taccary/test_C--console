namespace FootManager.Tests;

public class UnitTest1
{
    [Fact]
    public void Creation_Joueur()
    {
        var joueur = new Joueur("Lacazette", 34);

        Assert.Equal("Lacazette", joueur.Nom);
    }
}
