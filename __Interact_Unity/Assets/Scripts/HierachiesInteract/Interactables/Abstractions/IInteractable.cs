
using Visitors.Abstractions;

namespace HierachiesInteract.Interactables.Abstractions
{
    public interface IInteractable
    {
        void Accept(IInteractionVisitor visitor);
    }
}