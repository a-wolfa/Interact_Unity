using HierachiesInteract.Interactables;
using HierachiesInteract.Interactables.Abstractions;
using UnityEngine;
using Visitors;
using Visitors.Abstractions;
using Zenject;

namespace Installers
{
    public class InteractInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            AddVisitors();
        }
        
        private void AddVisitors()
        {
            Container.Bind<WoodenChestInteractable>().AsTransient();
            Container.Bind<MetalChestInterabtable>().AsTransient();
            
            Container.Bind<IInteractable>()
                .To<WoodenChestInteractable>()
                .FromResolve();

            Container.Bind<IInteractable>()
                .To<MetalChestInterabtable>()
                .FromResolve();
            
            
            Container.Bind<PlayerInteractionVisitor>().AsSingle();
            
            Container.Bind<IInteractionVisitor>()
                .To<PlayerInteractionVisitor>()
                .FromResolve();

            // Bind all interactable types
            
        }
    }
}
