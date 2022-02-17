using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
public class UserUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        text.text = $"Money {Math.Round((float)MoneyManager.GetMoneyAmount())} Lemonade {Lemonade_Stand.assetAmount} Bakery {Bakery.assetAmount}";



    }
}
