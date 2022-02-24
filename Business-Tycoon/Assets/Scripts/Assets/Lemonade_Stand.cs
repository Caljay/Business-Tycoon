using AssetInformation;
using UnityEngine;

public class Lemonade_Stand : MonoBehaviour, ICalculateProfits, IAsset
{ 
    public static int assetAmount;
    public static double price = 2;

    public  float profit = 5f;
    public  float costs = 3f;

    public static bool Buy()
    {
        

        float playerBal = (float)MoneyManager.GetMoneyAmount();
        if (price <= playerBal)
        {
            assetAmount++;
            MoneyManager.RemoveMoney(price);

            return true;
        }
        return false;

    }
    public void SendProfits()
    {
        var trueProfit = (profit * assetAmount) - (costs * assetAmount);
        MoneyManager.AddMoney((float)trueProfit);
    }
    

    private void OnMouseOver()
    {
        print("mouse entered not event");
    }
    private void Awake()
    {
        assetAmount++;


    }


}

