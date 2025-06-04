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
            Container.Bind<PlayerInteractionVisitor>().AsSingle();

            Container.Bind<IInteractionVisitor>()
                .To<PlayerInteractionVisitor>()
                .FromResolve();
        }
    }
}
