using UnityEngine;
using FMOD.Studio;

namespace Sonosthesia
{
    public class BusVolume : MonoBehaviour
    {

        [SerializeField] private string _path = "bus:/Nasty"; 
        
        [SerializeField] [Range(-80f, 10f)] private float _volume;

        private Bus _bus;
        
        protected virtual void Start()
        {
            _bus = FMODUnity.RuntimeManager.GetBus(_path);
        }

        protected virtual void Update()
        {
            _bus.setVolume(DecibelToLinear(_volume));
        }

        private float DecibelToLinear(float decibels)
        {
            return Mathf.Pow(10f, decibels / 20f);
        }
    }    
}


