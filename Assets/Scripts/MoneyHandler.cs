using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyHandler : MonoBehaviour
{
    public static int MoneyValue { get; private set; }
    
    public static Action OnMoneyChanged;
    public static Action OnMoneyLimitReached;

    private void Awake()
    {
        MoneyValue = 0;
    }

    public static void AddMoney()
    {
        MoneyValue++;
        OnMoneyChanged?.Invoke();
        
        if (MoneyValue >= GameParams.MoneyCount)
        {
            Debug.Log("reach");
            OnMoneyLimitReached?.Invoke();
        }
    }
    
}
