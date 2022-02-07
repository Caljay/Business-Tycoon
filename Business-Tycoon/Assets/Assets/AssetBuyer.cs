using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
