using AssetInformation;
using UnityEngine;

//asset or building
// LEVEL 2
public class Bakery : MonoBehaviour, IAsset
{
    public static int assetAmount;
    public static float profit = 10f;
    public static double currentPrice = 5;
    public static float costs = 7f;
 
    public static bool Buy()
    {
      

        var playerBal = MoneyManager.GetMoneyAmount();
        if (currentPrice <= playerBal)
        {
            assetAmount++;
            MoneyManager.RemoveMoney(currentPrice);
            return true;
        }
        return false;

    }
    public static void SendProfits()
    {
        var trueProfit = (profit * assetAmount) - (costs * assetAmount);
        MoneyManager.AddMoney((float)trueProfit);
    }
  

}
