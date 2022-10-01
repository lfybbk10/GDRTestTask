using Unity.VisualScripting;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private Camera _mainCamera;
    
    private CircleMoveHandler _circleMoveHandler;

    private void Awake() => _mainCamera = Camera.main;

    private void Start() => _circleMoveHandler = FindObjectOfType<CircleMoveHandler>();

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var mousePos = Input.mousePosition;
            if(!_circleMoveHandler.IsDestroyed())
                _circleMoveHandler.HandleClick(_mainCamera.ScreenToWorldPoint(mousePos));
        }
    }
}
