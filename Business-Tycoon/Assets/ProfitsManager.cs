using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfitsManager : MonoBehaviour
{

  

    [SerializeField] float taxRate = 0.125f;

    public void EndTurn()
    {
        CollectProfits();

    }
      void CollectProfits()
    {
        var placeholder = Lemonade_Stand.CalculateProfits();
        var placeholder2 = Bakery.CalculateProfits();
        // var placeholder = Lemonade_Stand.CalculateProfits();
        var profitEnd = placeholder + placeholder2;

       
        print(MoneyManager.GetMoneyAmount() * 0.5f);
        MoneyManager.RemoveMoney((MoneyManager.GetMoneyAmount() * taxRate));
    
        MoneyManager.AddMoney(profitEnd);
    }


}
