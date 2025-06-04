using Interactable;

namespace Visitors.Abstractions
{
    public interface IInteractionVisitor
    {
        // Define methods for interaction with different interactable types
        // Example:
        void Visit(TreasureChest treasureChest);
        void Visit(Door door);
    }
}