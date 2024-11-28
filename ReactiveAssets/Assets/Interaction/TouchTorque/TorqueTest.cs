using UnityEngine;

namespace Sonosthesia
{
    
#if UNITY_EDITOR
    using UnityEditor;

    [CustomEditor(typeof(TorqueTest))]
    public class TorqueTestEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            TorqueTest test = (TorqueTest)target;
            if(GUILayout.Button("Apply"))
            {
                test.Apply();
            }
        }
    }
#endif
    
    public class TorqueTest : MonoBehaviour
    {
        [SerializeField] private Rigidbody _target;
        [SerializeField] private bool _everyFixedUpdate;
        
        [SerializeField] private bool _relative;
        [SerializeField] private Vector3 _torque = Vector3.up;
        [SerializeField] private ForceMode _forceMode;

        [SerializeField] private Vector3 _accumulatedTorque;

        protected void FixedUpdate()
        {
            _accumulatedTorque = _target.GetAccumulatedTorque();
            
            if (_everyFixedUpdate)
            {
                Apply();
            }
        }

        public void Apply()
        {
            if (_relative)
            {
                _target.AddRelativeTorque(_torque, _forceMode);
            }
            else
            {
                _target.AddTorque(_torque, _forceMode);
            }
        }
    }    
}


