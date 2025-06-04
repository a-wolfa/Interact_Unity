using Interactable.Abstractions;
using UnityEngine;
using Visitors.Abstractions;

namespace Interactable
{
    public class TreasureChest : MonoBehaviour, IInteractable
    {
        public void Accept(IInteractionVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void Open()
        {
            Debug.Log("Chest Open");
        }
    }
}