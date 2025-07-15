using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinNumber : MonoBehaviour
{
    public int Number;
    public Canvas MyCanvas;
    private int _coinNumber;

    private void Start()
    {
        _coinNumber = FindObjectsOfType<Coin>().Length;
        Debug.Log($"Число монеток: {_coinNumber}");
    }

    private void Update()
    {
        if (Number >= _coinNumber)
        {
            MyCanvas.gameObject.SetActive(true);
        }
    }
}
