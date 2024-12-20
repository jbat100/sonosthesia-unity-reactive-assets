using Sonosthesia.Application;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Sonosthesia
{
    public class RootLifetimeScope : LifetimeScope
    {
        [SerializeField] private ApplicationConfiguration _applicationConfiguration;
        
        [SerializeField] private Hello _hello;

        protected override void Configure(IContainerBuilder builder)
        {
            ApplicationState state = new ApplicationState();
            // configure state as needed
            builder.RegisterInstance(_applicationConfiguration.SceneSwitcherSettings);
            SceneSwitcher switcher = new (_applicationConfiguration.SceneSwitcherSettings, state, this);
            builder.RegisterInstance(switcher).As<ISceneSwitcher>();
            builder.RegisterComponentInNewPrefab(_hello, Lifetime.Scoped);
        }
    }
}

