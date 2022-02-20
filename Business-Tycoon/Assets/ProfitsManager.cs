using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class ProfitsManager : MonoBehaviour
{

  

    [SerializeField] float taxRate = 0.125f;

    public void EndTurn()
    {
      

        CollectProfits();

    }
       void CollectProfits()
    {
        float profitEnd = 0;

       
       
        
        MoneyManager.RemoveMoney((MoneyManager.GetMoneyAmount() * taxRate));
        MoneyManager.CalculateAllProfits_();
        MoneyManager.AddMoney(profitEnd);
    }


}
