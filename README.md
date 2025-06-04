# Interact_Unity

A Unity project implementing an interaction system.

## Features
- **Interactor**: Handles player input and raycasts to interact with objects.
- **PlayerInteractionVisitor**: Implements the visitor logic for interactable objects.
- **Dependency Injection**: Uses Zenject to inject dependencies like PlayerInteractionVisitor.

## Project Structure
- `/Interactors/Interactor.cs`: Main player interaction logic.
- `/Visitors/PlayerInteractionVisitor.cs`: Visitor implementation for interactions.
- `/Interactable/`: Contains interactable interfaces and implementations.

## How It Works
1. **Interactor** listens for a key press (default: E).
2. On key press, it raycasts forward from the player.
3. If it hits an object implementing `IInteractable`, it calls `Accept(_interactionVisitor)`.
4. `PlayerInteractionVisitor` handles the interaction logic for any Interactables.

## Getting Started
1. Add the UnityPackage to your project.
2. Ensure Zenject is installed (see `Assets/Plugins/Zenject/`).
3. Add the `Interactor` script to your player GameObject.
4. Set up a Zenject Scene Context in your scene and Add the InteractInstaller to it as a MonoInstaller.
5. Create interactable objects implementing `IInteractable`.

## Example Zenject Installer
```csharp
using Zenject;
using Visitors;

public class ProjectInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<PlayerInteractionVisitor>().AsSingle();
    }
}
```

## License
MIT License

