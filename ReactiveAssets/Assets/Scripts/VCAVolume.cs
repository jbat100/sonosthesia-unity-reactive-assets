using UnityEngine;
using FMOD.Studio;

namespace Sonosthesia
{
    public class VCAVolume : MonoBehaviour
    {

        [SerializeField] private string _path = "vca:/Nasty"; 
        
        [SerializeField] [Range(-80f, 10f)] private float _volume;

        private VCA _vca;
        
        protected virtual void Start()
        {
            _vca = FMODUnity.RuntimeManager.GetVCA(_path);
        }

        protected virtual void Update()
        {
            _vca.setVolume(DecibelToLinear(_volume));
        }

        private float DecibelToLinear(float decibels)
        {
            return Mathf.Pow(10f, decibels / 20f);
        }
    }    
}


