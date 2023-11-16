using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera behindViewCamera;
    public Camera driverViewCamera;

    void Start()
    {
        behindViewCamera.GetComponent<Camera>().enabled = true;
        driverViewCamera.GetComponent<Camera>().enabled = false;
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            behindViewCamera.GetComponent<Camera>().enabled = true;
            driverViewCamera.GetComponent<Camera>().enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2)) {
            behindViewCamera.GetComponent<Camera>().enabled = false;
            driverViewCamera.GetComponent<Camera>().enabled = true;
        }
    }
}
