using UnityEngine;

public class GameParams : MonoBehaviour
{
    [SerializeField] private int _moneyCount;
    [SerializeField] private int _spikeCount;
    
    public static int MoneyCount { get; private set; }
    public static int SpikeCount { get; private set; }
    
    private void Awake()
    {
        MoneyCount = _moneyCount;
        SpikeCount = _spikeCount;
    }
}
