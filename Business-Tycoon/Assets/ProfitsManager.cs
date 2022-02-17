using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class ProfitsManager : MonoBehaviour
{

  

    [SerializeField] float taxRate = 0.125f;

    public void EndTurn()
    {
        MoneyManager.CalculateAllProfits();

        CollectProfits();

    }
       void CollectProfits()
    {
        float profitEnd = 0;

       
       
        print(MoneyManager.GetMoneyAmount() * 0.5f);
        MoneyManager.RemoveMoney((MoneyManager.GetMoneyAmount() * taxRate));
    
        MoneyManager.AddMoney(profitEnd);
    }


}
