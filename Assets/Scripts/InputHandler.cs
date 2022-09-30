using System;
using System.Collections;
using System.Collections.Generic;
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
            _circleMoveHandler.HandleClick(Camera.main.ScreenToWorldPoint(mousePos));
        }
    }
}
