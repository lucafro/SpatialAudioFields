using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _XRRig;
    [SerializeField]
    private GameObject _FPSController;

    private void OnEnable()
    {

#if UNITY_EDITOR
        _FPSController?.SetActive(true);
        _XRRig?.SetActive(false);

#elif UNITY_ANDROID
        _XRRig?.SetActive(true);
        _FPSController?.SetActive(false);
#endif

    }
}
