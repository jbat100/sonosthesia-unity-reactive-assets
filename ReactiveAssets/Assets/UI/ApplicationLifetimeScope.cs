using Sonosthesia.Application;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Sonosthesia
{
    public class ApplicationLifetimeScope : LifetimeScope
    {
        [SerializeField] private ApplicationConfiguration _applicationConfiguration;
        
        protected override void Configure(IContainerBuilder builder)
        {
            ApplicationState state = new ApplicationState();
            // configure state as needed
            
            builder.RegisterInstance(state);
            builder.RegisterInstance(_applicationConfiguration.ApplicationSettings);

            SceneSwitcher switcher = new (_applicationConfiguration.SceneSwitcherSettings, state, this);
            
            builder.RegisterInstance(switcher).As<ISceneSwitcher>();
        }
    }
}


