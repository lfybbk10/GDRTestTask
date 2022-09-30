using UnityEngine;


public class SpikeCollision : MonoBehaviour
{
    [SerializeField] private LayerMask _circleMask;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.IsInLayerMask(_circleMask))
        {
            other.GetComponent<CircleDieHandler>().Die();
        }
    }       
}
