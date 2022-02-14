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

        List<IPrint> prints = new List<IPrint>();
    foreach(var item in prints)
        {
            item.Print();
        }
    }


    #endregion

}
interface IPrint
{
    void Print();
}
class MyClass : IPrint
{
    void IPrint.Print()
    {
        Console.WriteLine("hello 1");
    }
}
class MyClass2 : IPrint
{
    void IPrint.Print()
    {
        Console.WriteLine("hello 2");

    }
}