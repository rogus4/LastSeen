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
    }

    void OnDisable()
    {
        IconController.cameraChange -= onCameraChange;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void onCameraChange(int newPos)
    {
        Vector3 pos2 = new Vector3(newPos, 0 , -10);
        transform.position = pos2;
        // Debug.Log("action ok " + newPos);
    }
}
