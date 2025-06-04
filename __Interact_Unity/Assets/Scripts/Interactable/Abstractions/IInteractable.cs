using Visitors.Abstractions;

namespace Interactable.Abstractions
{
    public interface IInteractable 
    {
        void Accept(IInteractionVisitor visitor);
    }
}
