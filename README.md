# test_C--console


## Structure du dépot
MonProjet/
├── .devcontainer/
│   └── devcontainer.json
├── src/
│   ├── Application/ ce dossier continet les élémenst d'interface utilisateur 
│   └── Domaine/ dans ce dossier on met les objets métier
└── tests/
    └── Domaine.Tests/



depuis la racine du dépot :

## Compiler :
```
dotnet build
```
construit tous les projets de la solution :
FootManager
FootManager.Tests


## Tester :
```
dotnet test
```
va :
construire la solution si nécessaire ;
exécuter tous les projets de tests.




## Executer :
```
dotnet run --project FootManager
```
compile et exécute le programme. 




# Créer le projet

dotnet new console -n FootManager
dotnet new xunit -n FootManager.Tests
dotnet new sln -n FootManager

dotnet sln add FootManager
dotnet sln add FootManager.Tests



dotnet add FootManager.Tests reference FootManager

dotnet new gitignore







Installer l'extension C# Dev Kit ???? il semble fallor se connecter avec microsoft pour utiliser ensuite....