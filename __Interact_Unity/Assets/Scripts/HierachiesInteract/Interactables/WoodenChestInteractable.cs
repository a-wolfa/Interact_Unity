using HierachiesInteract.Interactables.Abstractions;
using UnityEngine;
using Visitors.Abstractions;

namespace HierachiesInteract.Interactables
{
    public class WoodenChestInteractable : ChestInteractable
    {
        public override void Accept(IInteractionVisitor visitor)
        {
            visitor.Visit(this);
        }
        
        public override bool TryOpen()
        {
            if (!IsOpen)
            {
                Debug.Log("Opening the wooden chest.");
                IsOpen = true;
                return true;
            }

            Debug.Log("The wooden chest is already open.");
            return false;
        }
    }
}