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
            builder.RegisterInstance(_applicationConfiguration.SceneSwitcherSettings);

            builder.RegisterInstance(new SceneSwitcher(_applicationConfiguration.SceneSwitcherSettings, this)).As<ISceneSwitcher>();
            
            builder.RegisterComponentInNewPrefab(_hello, Lifetime.Scoped);
        }
    }
}

