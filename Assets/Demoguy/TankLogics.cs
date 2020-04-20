using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Complete;

public class TankLogics : MonoBehaviour
{
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) {
            CameraControl.cameraControl.focusList.Add(transform);
        }
    }

    void OnDestroy() {
         CameraControl.cameraControl.focusList.Remove(transform);
    }
}
