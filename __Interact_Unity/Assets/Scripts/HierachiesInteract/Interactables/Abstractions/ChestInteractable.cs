using System.Collections.Generic;
using UnityEngine;
using Visitors.Abstractions;

namespace HierachiesInteract.Interactables.Abstractions
{
    public abstract class ChestInteractable : MonoBehaviour, IInteractable
    {
        [SerializeField] protected bool IsOpen = false;
        [SerializeField] protected List<string> Items;

        public abstract void Accept(IInteractionVisitor visitor);

        public abstract bool TryOpen();

        public virtual void LootItems()
        {
            foreach (var item in Items)
            {
                Debug.Log($"Looted item: {item}");
            }
        }
    }
}