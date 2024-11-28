using UnityEngine;
using FMOD.Studio;
using FMODUnity;
using STOP_MODE = FMOD.Studio.STOP_MODE;

namespace Sonosthesia
{
    public class Snapshot : MonoBehaviour
    {
        [SerializeField] private EventReference _snapshot;

        private EventInstance _instance;

        private void Cleanup()
        {
            _instance.stop(STOP_MODE.ALLOWFADEOUT);
            _instance.release();
        }
        
        protected virtual void OnEnable()
        {
            Cleanup();
            
            _instance = RuntimeManager.CreateInstance(_snapshot);
            _instance.start();
        }

        protected virtual void OnDisable()
        {
            Cleanup();
        }
    }    
}


