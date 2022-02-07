using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfitsManager : MonoBehaviour
{
    
    public void EndTurn()
    {
        CollectProfits();

    }
      void CollectProfits()
    {
        var placeholder = Lemonade_Stand.CalculateProfits();
        var placeholder2 = Bakery.CalculateProfits();
        // var placeholder = Lemonade_Stand.CalculateProfits();
        var _profitEnd = placeholder + placeholder2;

        var profitEnd = _profitEnd * 0.9f;
        print(MoneyManager.GetMoneyAmount() * 0.5f);
        MoneyManager.RemoveMoney((MoneyManager.GetMoneyAmount() * 0.5f));
       // MoneyManager.AddMoney(MoneyManager.GetMoneyAmount() - (MoneyManager.GetMoneyAmount() * 0.5f));
        //MoneyManager.AddMoney(profitEnd);
    }


}
