using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class CircleMoveHandler : MonoBehaviour
{
    [SerializeField] private LineRenderer _lineRenderer;
    
    private List<Vector3> movePositions = new List<Vector3>();
    private bool isMoving;

    private void OnEnable()
    {
        EndGameHandler.OnWinGame += DisableHandler;
        EndGameHandler.OnLoseGame += DisableHandler;
    }

    private void OnDisable()
    {
        EndGameHandler.OnWinGame -= DisableHandler;
        EndGameHandler.OnLoseGame -= DisableHandler;
    }

    private void Start()
    {
        _lineRenderer.positionCount++;
        _lineRenderer.SetPosition(0,transform.position);
    }

    private void Update()
    {
        if (!isMoving && movePositions.Count > 0 && transform.position != movePositions[0])
        {
            Move();
        }
    }

    public void HandleClick(Vector2 position)
    {
        if(!enabled)
            return;
        
        movePositions.Add(position);
        
        _lineRenderer.positionCount++;
        _lineRenderer.SetPosition(_lineRenderer.positionCount - 1,position);
    }

    private void Move()
    {
        isMoving = true;
        transform.DOMove(movePositions[0], 1).OnComplete(() =>
        {
            movePositions.Remove(movePositions[0]);
            isMoving = false;
        });
    }

    private void DisableHandler()
    {
        DOTween.KillAll();
        movePositions.Clear();
        enabled = false;
    }
}
