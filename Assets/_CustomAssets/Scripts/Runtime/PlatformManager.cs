using UnityEngine;

/// <summary>
/// Automatically switch between XR rig and FPS controller depending on platform.
/// </summary>

namespace Lucafro.Runtime
{
    public class PlatformManager : MonoBehaviour
    {
        [Header("References")]
        [SerializeField, Tooltip("Reference to the XR camera rig.")]
        private GameObject _XRRig;
        [SerializeField, Tooltip("Reference to FPS controller.")]
        private GameObject _FPSController;

        private void Start()
        {
#if UNITY_EDITOR
            if (_XRRig && _FPSController)
            {
                _XRRig.SetActive(false);
                _FPSController.SetActive(true);
            }
#elif UNITY_ANDROID
        if (_XRRig && _FPSController)
        {
            _XRRig.SetActive(true);
            _FPSController.SetActive(false);
        }
#endif
        }
    }
}
