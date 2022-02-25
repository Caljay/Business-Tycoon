using AssetInformation;
using System;
public class Lemonade_Stand : ICalculateProfits, IAsset
{

    public Lemonade_Stand()
    {
        BuiltAssets.AddAsset(this);
        
        

    }
    ~Lemonade_Stand()
    {
        BuiltAssets.RemoveAsset(this);
        


    }

    public static int assetAmount;
    public static float basePrice = 2;

    public double currentPrice = 2;
    public float profit = 5f;
    public  float costs = 3f;

    public void SendProfits()
    {
        var trueProfit = (profit * assetAmount) - (costs * assetAmount);
        MoneyManager.AddMoney((float)trueProfit);
    }

   
}
