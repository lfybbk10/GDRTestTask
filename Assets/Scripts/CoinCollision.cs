using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollision : MonoBehaviour
{
    [SerializeField] private LayerMask _circleMask;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.IsInLayerMask(_circleMask))
        {
            Destroy(gameObject, 0.1f);
            MoneyHandler.AddMoney();
        }
    }
}
