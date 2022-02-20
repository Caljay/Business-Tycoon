using System.Collections;
using System.Collections.Generic;

public class Lemonade_Stand : MoneyManager.ICalculateProfits
{ 
    public static int assetAmount;

    static int startPrice = 2;
   static float multiplier = 1.0625f;
   public static double currentPrice { get; private set;  }
   static float profit = 5f;
   static float costs = 3f;


    public static void CalculateNewPrices()
    {
        currentPrice = startPrice * (System.Math.Pow(multiplier, assetAmount));





    }
    public static void Buy()
    {
        CalculateNewPrices();

        float playerBal = (float)MoneyManager.GetMoneyAmount();
        if (currentPrice <= playerBal)
        {
            assetAmount++;
            MoneyManager.RemoveMoney(currentPrice);
        }


    }
    public static void SendProfits()
    {
        var trueProfit = (profit * assetAmount) - (costs * assetAmount);
        MoneyManager.AddMoney((float)trueProfit);
    }
 
  
}
