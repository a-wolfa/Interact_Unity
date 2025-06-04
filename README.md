# Interact_Unity

A Unity project implementing an interaction system using the Visitor pattern and Zenject for dependency injection.

## Features
- **Interactor**: Handles player input and raycasts to interact with objects.
- **PlayerInteractionVisitor**: Implements the visitor logic for interactable objects.
- **Dependency Injection**: Uses Zenject to inject dependencies like PlayerInteractionVisitor.

## Project Structure
- `Assets/Scripts/Interactors/Interactor.cs`: Main player interaction logic.
- `Assets/Scripts/Visitors/PlayerInteractionVisitor.cs`: Visitor implementation for interactions.
- `Assets/Scripts/Interactable/`: Contains interactable interfaces and implementations.
- `Assets/Plugins/Zenject/`: Zenject dependency injection framework.

## How It Works
1. **Interactor** listens for a key press (default: E).
2. On key press, it raycasts forward from the player.
3. If it hits an object implementing `IInteractable`, it calls `Accept(_interactionVisitor)`.
4. `PlayerInteractionVisitor` handles the interaction logic.

## Dependency Injection Setup
- Zenject is used to inject `PlayerInteractionVisitor` into `Interactor`.
- Add a Zenject installer (e.g., `ProjectInstaller`) to bind `PlayerInteractionVisitor` as a singleton or as needed.

## Getting Started
1. Open the project in Unity.
2. Ensure Zenject is installed (see `Assets/Plugins/Zenject/`).
3. Add the `Interactor` script to your player GameObject.
4. Set up a Zenject installer to bind `PlayerInteractionVisitor`.
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

## Requirements
- Unity 2021 or newer
- Zenject (included in Plugins)

## License
MIT License

