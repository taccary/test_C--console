namespace FootManager.Models;

public class Joueur
{
    private string _nom; // Cattribut privé pour stocker le nom 
    private int _age; // attribut privé pour stocker l'âge


    // Constructeur qui valorise les attributs privés _nom et _age avec les valeurs passées en paramètres
    public Joueur(string nom, int age)
    {
        this._nom = nom;
        this._age = age;
    }


    // Propriété Nom avec accesseurs get et set et validation du nom dans le set
    public string Nom
    {
        get { return this._nom; }
        set { 
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Nom invalide");
            }
            this._nom = value; 
            }
    }

    // Propriété Age avec accesseurs get et set et validation de l'âge dans le set
    public int Age
    {
        get { return this._age; }

        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Age invalide");
            }

            this._age = value;
        }
    }

    // Redéfinition de la méthode ToString pour retourner une représentation textuelle de l'objet Joueur
    public override string ToString()
    {
        return $"{this.Nom} ({this.Age} ans)";
    }
}