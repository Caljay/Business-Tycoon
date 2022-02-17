using System.Collections;
using System.Collections.Generic;

public class Lemonade_Stand : MoneyManager.ICalculateProfits
{ 
    public static int assetAmount;

    static int startPrice = 2;
   static float multiplier = 1.0625f;
   static double currentPrice;
   static float profit = 5;
   static float costs = 0;


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
