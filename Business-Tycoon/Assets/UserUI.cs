using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class UserUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;


    // Update is called once per frame
    void Update()
    {
        string displayText = $"Money: {Mathf.Round((float)MoneyManager.GetMoneyAmount())}\nLemonade Stands: {Lemonade_Stand.assetAmount}\nBakeries: {Bakery.assetAmount}\n";
        text.text = displayText;
        


    }
}
