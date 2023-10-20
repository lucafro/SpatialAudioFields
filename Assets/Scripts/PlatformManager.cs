using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    public GameObject FPSController;
    public GameObject VRPlayer;

    void Awake()
    {
#if UNITY_EDITOR
        FPSController.SetActive(true);
        VRPlayer.SetActive(false);
#endif

#if UNITY_ANDROID
        VRPlayer.SetActive(true);
        FPSController.SetActive(false);
        //UnityEngine.XR.XRSettings.eyeTextureResolutionScale = 2.0f;
#endif
    }

    void Update()
    {

    }
}
