using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bakery 
{
    static int startPrice = 2;
   public static int assetAmount;
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
