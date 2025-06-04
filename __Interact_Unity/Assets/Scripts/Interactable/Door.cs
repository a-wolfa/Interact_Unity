using Interactable.Abstractions;
using UnityEngine;
using Visitors.Abstractions;

namespace Interactable
{
    public class Door : MonoBehaviour, IInteractable
    {
        [SerializeField] private bool isLocked = false;

        public void Accept(IInteractionVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void Open()
        {
            Debug.Log("Door Open");
        }
        
        public bool IsLocked => isLocked;
    }
}