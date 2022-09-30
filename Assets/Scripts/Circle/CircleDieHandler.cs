using System;
using DG.Tweening;
using UnityEngine;

public class CircleDieHandler : MonoBehaviour
{
    public Action OnDied;

    public void Die()
    {
        DOTween.KillAll();
        OnDied?.Invoke();
        Destroy(gameObject,0.2f);
    }
}
