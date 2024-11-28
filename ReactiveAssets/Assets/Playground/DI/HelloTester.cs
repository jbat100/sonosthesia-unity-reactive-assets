using UnityEngine;
using VContainer;

namespace Sonosthesia
{
    public class HelloTester : MonoBehaviour
    {
        private Hello _hello;
        
        [Inject]
        public void Construct(Hello hello)
        {
            _hello = hello;
        }
    }
}


