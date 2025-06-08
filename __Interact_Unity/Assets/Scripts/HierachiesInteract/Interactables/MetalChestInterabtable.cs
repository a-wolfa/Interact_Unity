using HierachiesInteract.Interactables.Abstractions;
using UnityEngine;
using Visitors.Abstractions;

namespace HierachiesInteract.Interactables
{
    public class MetalChestInterabtable : ChestInteractable
    {
        [SerializeField] public bool _isLocked = false;
        
        public override void Accept(IInteractionVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override bool TryOpen()
        {
            if (_isLocked)
            {
                TryUnlock();
                return false;
            }

            Debug.Log("The metal chest is open.");
            return IsOpen = true;
        }

        public bool TryUnlock()
        {
            Debug.Log("The Lock is broken, you can open the chest now.");
            _isLocked = false;
            return true;
        }
    }
}