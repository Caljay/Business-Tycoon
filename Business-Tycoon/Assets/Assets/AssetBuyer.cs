using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
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
    
    public void DoStuff(string msg)
    {
        print(msg);
    }
    private void Start()
    {

  
    }


    #endregion

}
