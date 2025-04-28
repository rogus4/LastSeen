using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ReturnController : MonoBehaviour
{
    public static event Action<int, int> cameraChange2;
    private int PosXatual = 0;
    private int PosYatual = 0;
    private int PosXantiga = 0;
    private int PosYantiga = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnable()
    {
        IconController.cameraChange += onCameraChange;
        RetClickController.RetClicked += RetClicked;
    }

    void OnDisable()
    {
        IconController.cameraChange -= onCameraChange;
        RetClickController.RetClicked -= RetClicked;
    }

    void onCameraChange(int newPosX, int newPosY)
    {
        PosXantiga = PosXatual;
        PosYantiga = PosYatual;
        PosXatual = newPosX;
        PosYatual = newPosY;
        // Debug.Log("AntesX: " + PosXantiga + " AntesY: " + PosYantiga + " AtualX: " + PosXatual + " AtualY: " + PosYatual);
    }

    void RetClicked(int x, int y)
    {
        cameraChange2?.Invoke(PosXantiga, PosYantiga);
        onCameraChange(PosXantiga, PosYantiga);
    }
}
