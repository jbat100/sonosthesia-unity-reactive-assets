using Sonosthesia.Dynamic;
using UnityEngine;

namespace Sonosthesia
{
    public class TransformDynamicsVisual : MonoBehaviour
    {
        [SerializeField] private TransformDynamicsMonitor _monitor;

        [SerializeField] private float _scaleOffset = 0.1f;
        [SerializeField] private float _positionScaleFactor = 0.1f;
        [SerializeField] private float _rotationScaleFactor = 0.001f;
        
        [Header("Visual")]
        
        [SerializeField] private Transform _velocity;
        [SerializeField] private Transform _acceleration;
        [SerializeField] private Transform _jerk;

        protected virtual void Update()
        {
            if (!_monitor)
            {
                return;
            }

            Apply(_monitor.Velocity, _velocity);
            Apply(_monitor.Acceleration, _acceleration);
            Apply(_monitor.Jerk, _jerk);
        }

        protected virtual void Apply(TransformDynamics.Data data, Transform target)
        {
            if (!target)
            {
                return;
            }
            
            float x = data.Rotation.magnitude * _rotationScaleFactor + _scaleOffset;
            float y = data.Position.magnitude * _positionScaleFactor + _scaleOffset;

            Vector3 localScale = target.localScale;
            localScale.x = x;
            localScale.y = y;
            target.localScale = localScale;
        }
    }
}
