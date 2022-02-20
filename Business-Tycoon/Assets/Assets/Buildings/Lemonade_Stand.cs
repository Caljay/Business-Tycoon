using AssetInformation;

public class Lemonade_Stand : ICalculateProfits, IAsset
{ 
    public static int assetAmount;
    public static double currentPrice = 2;
    public static float profit = 5f;
    public static float costs = 3f;

     static float multiplier = 1.0625f;


    public static void CalculateNewPrices()
    {
        currentPrice = currentPrice * (System.Math.Pow(multiplier, assetAmount));





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
