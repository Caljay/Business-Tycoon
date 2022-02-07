using System.Collections;
using System.Collections.Generic;

public class Lemonade_Stand
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

        var playerBal = MoneyManager.GetMoneyAmount();
        if (currentPrice <= playerBal)
        {
            assetAmount++;
            MoneyManager.RemoveMoney(currentPrice);
        }


    }
    public static float CalculateProfits()
    {
        var trueProfit = (profit * assetAmount) - (costs * assetAmount);
        return (float)trueProfit;
    }


}
