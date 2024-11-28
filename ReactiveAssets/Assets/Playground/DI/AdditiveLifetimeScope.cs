using System;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Sonosthesia
{
    public class Silly : IDisposable
    {
        public void Speak()
        {
            Debug.Log($"I'm silly");
        }
        
        public void Dispose()
        {
            Debug.Log($"{nameof(Silly)} {nameof(Dispose)}");
        }
    }
    
    public class AdditiveLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterInstance(new Silly());
        }
    }
}


