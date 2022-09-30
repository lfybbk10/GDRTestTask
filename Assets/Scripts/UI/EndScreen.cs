using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EndScreen : MonoBehaviour
{
    [SerializeField] private GameObject _endScreen;
    [SerializeField] private TextMeshProUGUI _label;

    private void OnEnable()
    {
        EndGameHandler.OnWinGame += WinGame;
        EndGameHandler.OnLoseGame += LoseGame;
    }
    
    private void OnDisable()
    {
        EndGameHandler.OnWinGame -= WinGame;
        EndGameHandler.OnLoseGame -= LoseGame;
    }

    private void WinGame()
    {
        print("win");
        _endScreen.SetActive(true);
        _label.color = Color.green;
        _label.SetText("Победа!");
    }
    
    private void LoseGame()
    {
        _endScreen.SetActive(true);
        _label.color = Color.red;
        _label.SetText("Поражение!");
    }
}
