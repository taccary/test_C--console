using FootManager.Models;

List<Joueur> joueurs = new();
List<Equipe> equipes = new();

int choix;

do
{
    Console.WriteLine();
    Console.WriteLine("===== FOOT MANAGER =====");
    Console.WriteLine("1 - Créer un joueur");
    Console.WriteLine("2 - Créer une équipe");
    Console.WriteLine("3 - Affecter un joueur à une équipe");
    Console.WriteLine("4 - Afficher les équipes");
    Console.WriteLine("0 - Quitter");

    Console.Write("Votre choix : ");
    int.TryParse(Console.ReadLine(), out choix);

    switch (choix)
    {
        case 1:
            CreerJoueur();
            break;

        case 2:
            CreerEquipe();
            break;

        case 3:
            AffecterJoueur();
            break;

        case 4:
            AfficherEquipes();
            break;
    }

} while (choix != 0);


void CreerJoueur()
{
    Console.Write("Nom du joueur : ");
    string nom = Console.ReadLine()!;

    Console.Write("Age : ");
    int age = int.Parse(Console.ReadLine()!);

    joueurs.Add(new Joueur(nom, age));

    Console.WriteLine("Joueur créé.");
}


void CreerEquipe()
{
    Console.Write("Nom de l'équipe : ");
    string nom = Console.ReadLine()!;

    equipes.Add(new Equipe(nom));

    Console.WriteLine("Equipe créée.");
}


void AffecterJoueur()
{
    if (joueurs.Count == 0 || equipes.Count == 0)
    {
        Console.WriteLine("Créer d'abord des joueurs et des équipes.");
        return;
    }

    Console.WriteLine();
    Console.WriteLine("=== Joueurs ===");

    for (int i = 0; i < joueurs.Count; i++)
    {
        Console.WriteLine($"{i} - {joueurs[i]}");
    }

    Console.Write("Choisir un joueur : ");
    int indexJoueur = int.Parse(Console.ReadLine()!);

    Console.WriteLine();
    Console.WriteLine("=== Equipes ===");

    for (int i = 0; i < equipes.Count; i++)
    {
        Console.WriteLine($"{i} - {equipes[i].Nom}");
    }

    Console.Write("Choisir une équipe : ");
    int indexEquipe = int.Parse(Console.ReadLine()!);

    equipes[indexEquipe].AjouterJoueur(joueurs[indexJoueur]);

    Console.WriteLine("Joueur affecté.");
}


void AfficherEquipes()
{
    Console.WriteLine();

    foreach (Equipe equipe in equipes)
    {
        Console.WriteLine($"Equipe : {equipe.Nom}");

        if (equipe.Joueurs.Count == 0)
        {
            Console.WriteLine("  Aucun joueur");
        }
        else
        {
            foreach (Joueur joueur in equipe.Joueurs)
            {
                Console.WriteLine($"  - {joueur}");
            }
        }

        Console.WriteLine();
    }
}