using HierachiesInteract.Interactables.Abstractions;
using UnityEngine;
using Visitors.Abstractions;
using Zenject;

namespace Interactors
{
    public class Interactor : MonoBehaviour
    {
        public float interactionDistance = 3f;
        public KeyCode interactKey = KeyCode.E;
        
        public new UnityEngine.Camera camera;

        [Inject] private IInteractionVisitor _interactionVisitor;

        private void Update()
        {
            if (Input.GetKeyDown(interactKey))
            {
                Interact();
            }
        }

        private void Interact()
        {
            Ray ray = new(transform.position,  camera.transform.forward);
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