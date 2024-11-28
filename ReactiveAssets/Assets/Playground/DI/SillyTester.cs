using UnityEngine;
using VContainer;

namespace Sonosthesia
{
    public class SillyTester : MonoBehaviour
    {
        private Silly _silly;

        private Hello _hello;
        
        [Inject]
        public void Construct(Silly silly, Hello hello)
        {
            _silly = silly;
            _hello = hello;
        }

        protected void OnEnable()
        {
            _silly.Speak();

            _hello.name += "_silly";
        }
    }    
}

