using AssetInformation;
using UnityEngine;

//asset or building LS 
// LEVEL 1
public class Lemonade_Stand :  IAsset
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
    public float profit = 50000f;
    public float costs = 3f;

    public float GetProfits()
    {
        return profit - costs;
    }


   
}
