# AutoClicker (Avalonia GUI)

Un auto-clicker simple développé en C# utilisant le framework UI Avalonia.

## 🚀 Fonctionnalités
* Activation/Désactivation des clics automatiques via une touche de raccourci (hotkey).
* Bouton Start/Stop directement dans l’interface graphique.
* Intervalle entre les clics configurable.

## 📋 Prérequis
* Visual Studio Code (ou tout autre IDE C#)
* [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) ou supérieur
* L'extension C# pour VS Code (recommandée pour Avalonia et le débogage).

Assurez-vous que `dotnet` est correctement installé et accessible dans votre PATH :
```bash
dotnet --version
```

## 💾 Installation et Lancement

### 1. Cloner le projet

Dans votre terminal, clonez ce dépôt :
```bash
git clone https://github.com/nezzeur/AutoClicker.git
```

### 2. Ouvrir le projet

Naviguez dans le dossier nouvellement créé et ouvrez-le avec VS Code :
```bash
cd AutoClicker
code .
```


### 3. Lancer le projet

Utilisez le terminal intégré de VS Code pour exécuter l'application :
```bash
dotnet run
```

Une fenêtre Avalonia s’ouvrira.

## ⌨️ Utilisation

Vous pouvez contrôler l'auto-clicker de deux manières :
- Touche de raccourci : Appuyez sur Flèche Haut pour démarrer ou arrêter les clics.
- Interface : Cliquez sur le bouton Start/Stop.

## ⚙️ Configuration de l'intervalle

Modifiez la vitesse des clics (en millisecondes) :
- Via l'interface : Utilisez la TextBox prévue à cet effet dans la fenêtre de l'application.
- Dans le code (valeur par défaut) : Ouvrez le fichier `MainWindow.axaml.cs` et modifiez la variable :

```bash
public int clickInterval = 5; // Intervalle en millisecondes
```





















