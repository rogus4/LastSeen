using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

// Esse script pode ser adicionado a um objeto que seja pai 
// de uma colecao de objetos que desejamos permitir o jogador de mexer 
// verticalmente. Os valores minimo e maximo definem os limites do scroll.
public class ScrollController : MonoBehaviour
{
    [SerializeField]
    private float minimo;
    [SerializeField]
    private float maximo;
    private Vector3 inicialPosition;
    private Vector3 ressetPosition;
    private bool dragging = false;
    private Vector3 posClick = new Vector3(0,0,0);
    private Vector3 newPos = new Vector3(0,0,0);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ressetPosition = transform.position;
    }

    //se inscre no evento
    void OnEnable()
    {
        IconController.cameraChange += onCameraChange;
    }

    //se desinscre no evento
    void OnDisable()
    {
        IconController.cameraChange -= onCameraChange;
    }

    void Update()
    {
        if (dragging)
        {
            newPos = posClick - Camera.main.ScreenToWorldPoint(Input.mousePosition) + inicialPosition;
            newPos.x = inicialPosition.x;

            //Limita o scroll
            if (newPos.y < ressetPosition.y+minimo)
            {
                newPos.y = ressetPosition.y+minimo;
            }
            if (newPos.y > ressetPosition.y+maximo)
            {
                newPos.y = ressetPosition.y+maximo;
            }
            transform.position = newPos;
        }
    }
    
void OnMouseDown()
    {
        inicialPosition = transform.position;
        posClick = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        dragging = true;
    }

void OnMouseUp()
    {
        dragging = false;
    }
	
    //volta as imagens a posicao inicial depois de uma mudanca de tela
    void onCameraChange(int newPosX, int newPosY)
    {
        transform.position = ressetPosition;
    }
}
