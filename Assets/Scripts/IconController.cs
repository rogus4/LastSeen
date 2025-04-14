using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


public class IconController : MonoBehaviour
{
    [SerializeField]
    private int destino;

    public static event Action<int> cameraChange;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        cameraChange?.Invoke(destino);
    }
}
