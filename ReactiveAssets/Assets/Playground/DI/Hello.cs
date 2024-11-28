using UnityEngine;

namespace Sonosthesia
{
    public class Hello : MonoBehaviour, IHello
    {
        protected void Awake()
        {
            Debug.Log("Hello Awake");
        }
        
        protected void OnDestroy()
        {
            Debug.Log("Hello OnDestroy");
        }
    }    
}

