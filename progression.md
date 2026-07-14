séparation

### Ce qui relève de l'interface utilisateur

Ça reste dans `Program.cs` :

```csharp
Console.Write("Nom du joueur : ");
string nom = Console.ReadLine();

Console.WriteLine("Joueur créé");
```

ou

```csharp
AfficherMenu();
```

L'objectif est que `Program.cs` soit responsable des échanges avec l'utilisateur.

***

### Ce qui relève du métier

Ça pourrait aller dans un service.

Par exemple, dans mon exemple :

```csharp
equipes[indexEquipe].AjouterJoueur(joueurs[indexJoueur]);
```

peut rester dans `Equipe` au début.

Mais plus tard, si la règle devient :


```

***

### Une progression pédagogique naturelle

#### Étape 1

Tout dans `Program.cs`

```text
Program.cs
Joueur.cs
Equipe.cs
```

Les étudiants découvrent les classes.

***

#### Étape 2

Les comportements dans les modèles.

```csharp
equipe.AjouterJoueur(joueur);
```

```csharp
equipe.RetirerJoueur(joueur);
```

Les étudiants apprennent qu'un objet possède aussi des méthodes.

***

#### Étape 3

Introduction d'un service.

```csharp
GestionEquipeService
```

qui gère :

```csharp
AffecterJoueur(...)
TransfererJoueur(...)
```

Là on aborde la notion de responsabilité.

***

#### Étape 4

`Program.cs` devient très léger.

```csharp
var service = new GestionEquipeService();

service.AffecterJoueur(
    joueur,
    equipe
);
```

et toute la logique métier est ailleurs.

***

Personnellement, pour des SIO1, je ne créerais **pas de dossier `Services` dès le premier TP**.

Je ferais :

```text
FootManager
├── Models
│   ├── Joueur.cs
│   └── Equipe.cs
└── Program.cs
```

Puis, quand `Program.cs` commence à dépasser 150-200 lignes ou quand les règles métier se multiplient, j'introduirais :

```text
FootManager
├── Models
├── Services
│   └── GestionEquipeService.cs
└── Program.cs
```

C'est d'ailleurs une bonne occasion d'expliquer **pourquoi** on refactorise : non pas parce que "l'architecture l'exige", mais parce que le programme devient difficile à maintenir. C'est généralement beaucoup mieux compris par les étudiants.
