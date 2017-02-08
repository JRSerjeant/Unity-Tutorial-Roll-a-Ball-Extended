using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour {
    public Camera mainCamera;
    public Camera twoDCamera;
    bool toggle;
    private void Start()
    {
        mainCamera.enabled = true;
        twoDCamera.enabled = false;
    }


    public void CameraSwitch()
    {
        if(toggle)
        {
            twoDCamera.enabled = false;
            mainCamera.enabled = true;
            toggle = false;
            return;
        }

        twoDCamera.enabled = true;
        mainCamera.enabled = false;
        toggle = true;
    }
}
