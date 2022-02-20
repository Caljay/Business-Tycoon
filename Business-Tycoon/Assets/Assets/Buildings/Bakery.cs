using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bakery : MoneyManager.ICalculateProfits
{
    static int startPrice = 2;
   public static int assetAmount;
    static float multiplier = 1.0625f;
    static double currentPrice;
    static float profit = 10f;
    static float costs = 7f;


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
    public static void SendProfits()
    {
        var trueProfit = (profit * assetAmount) - (costs * assetAmount);
        MoneyManager.AddMoney((float)trueProfit);
    }
  

}
