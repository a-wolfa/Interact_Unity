using Interactable.Abstractions;
using UnityEngine;
using Visitors;
using Zenject;

namespace Interactors
{
    public class Interactor : MonoBehaviour
    {
        public float interactionDistance = 3f;
        public KeyCode interactKey = KeyCode.E;

        [Inject] private PlayerInteractionVisitor _interactionVisitor;

        private void Update()
        {
            if (Input.GetKeyDown(interactKey))
            {
                Interact();
                Debug.Log("Interaction triggered");
            }
        }

        private void Interact()
        {
            Ray ray = new(transform.position, transform.forward);
            if (Physics.Raycast(ray, out RaycastHit hit, interactionDistance))
            {
                if (hit.collider.TryGetComponent(out IInteractable interactable))
                {
                    interactable.Accept(_interactionVisitor);
                }
            }
        }
    }
}