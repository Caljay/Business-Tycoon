using AssetInformation;

public class Bakery : ICalculateProfits, IAsset
{
    public static int assetAmount;
    public static float profit = 10f;
    public static double currentPrice = 2;
    public static float costs = 7f;


     static float multiplier = 1.0625f;


    public static void CalculateNewPrices()
    {
        currentPrice = currentPrice * (System.Math.Pow(multiplier, assetAmount));





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
