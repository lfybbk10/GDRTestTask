using System;
using UnityEngine;


public class EndGameHandler : MonoBehaviour
{
    private CircleDieHandler _circleDieHandler;
    
    public static Action OnWinGame;
    public static Action OnLoseGame;

    private void Awake() => _circleDieHandler = FindObjectOfType<CircleDieHandler>();

    private void OnEnable()
    {
        MoneyHandler.OnMoneyLimitReached += WinGame;
        _circleDieHandler.OnDied += LoseGame;
    }

    private void OnDisable()
    {
        MoneyHandler.OnMoneyLimitReached -= WinGame;
        _circleDieHandler.OnDied -= LoseGame;
    }

    private void WinGame() => OnWinGame?.Invoke();

    private void LoseGame() => OnLoseGame?.Invoke();
}
