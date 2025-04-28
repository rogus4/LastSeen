using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class CameraControler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void OnEnable()
    {
        IconController.cameraChange += onCameraChange;
        ReturnController.cameraChange2 += onCameraChange;
    }

    void OnDisable()
    {
        IconController.cameraChange -= onCameraChange;
        ReturnController.cameraChange2 -= onCameraChange;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void onCameraChange(int newPosX, int newPosY)
    {
        Vector3 pos2 = new Vector3(newPosX, newPosY , -10);
        transform.position = pos2;
        // Debug.Log("action ok " + newPos);
    }
}
