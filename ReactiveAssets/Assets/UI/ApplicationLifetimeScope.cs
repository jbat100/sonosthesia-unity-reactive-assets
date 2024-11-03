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
            builder.RegisterInstance(_applicationConfiguration.ApplicationSettings);
            
            builder.RegisterInstance(new SceneSwitcher(_applicationConfiguration.SceneSwitcherSettings, this))
                .As<ISceneSwitcher>();
        }
    }
}


