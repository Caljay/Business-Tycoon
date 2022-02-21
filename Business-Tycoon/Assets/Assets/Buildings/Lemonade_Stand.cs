using AssetInformation;

public class Lemonade_Stand : ICalculateProfits, IAsset
{ 
    public static int assetAmount;
    public static double currentPrice = 2;
    public static float profit = 5f;
    public static float costs = 3f;

    public static bool Buy()
    {
        

        float playerBal = (float)MoneyManager.GetMoneyAmount();
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
