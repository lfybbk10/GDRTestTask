using System;
using TMPro;
using UnityEngine;


public class MoneyText : MonoBehaviour
{
    private TextMeshProUGUI _textMeshPro;

    private void Awake()
    {
        _textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        MoneyHandler.OnMoneyChanged += UpdateText;
    }

    private void OnDisable()
    {
        MoneyHandler.OnMoneyChanged -= UpdateText;
    }

    private void UpdateText()
    {
        _textMeshPro.SetText($"Money: {MoneyHandler.MoneyValue}");
    }
    
    
}
