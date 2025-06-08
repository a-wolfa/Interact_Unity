using HierachiesInteract.Interactables;
using HierachiesInteract.Interactables.Abstractions;
using Interactable;

namespace Visitors.Abstractions
{
    public interface IInteractionVisitor
    {
        // Define methods for interaction with different interactable types
        // Example:
        void Visit(TreasureChest treasureChest);
        void Visit(Door door);
        
        void Visit(MetalChestInterabtable metalChest);
        
        void Visit(WoodenChestInteractable woodenChestInteractable);
    }
}