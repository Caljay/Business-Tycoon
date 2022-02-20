using UnityEngine;

public class AssetBuyer : MonoBehaviour
{
    #region simple shops 
    public void BuyLemonadeStand()
    {
        Lemonade_Stand.Buy();
    }
    public void BuyBakery()
    {
        Bakery.Buy();
    }


    #endregion

}
