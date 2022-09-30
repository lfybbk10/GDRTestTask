using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private CircleMoveHandler _circleMoveHandler;

    private void Start()
    {
        _circleMoveHandler = FindObjectOfType<CircleMoveHandler>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var mousePos = Input.mousePosition;
            if(!_circleMoveHandler.IsDestroyed())
                _circleMoveHandler.HandleClick(Camera.main.ScreenToWorldPoint(mousePos));
        }
    }
}
