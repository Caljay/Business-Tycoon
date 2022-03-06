using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using AssetInformation;

public static class MoneyManager
{
    private static double money = 100;
    static List<Type> theTypes = new();
    #region Low Level

    /// <summary>
    /// removes money from the player balance
    /// </summary>
    /// <param name="charge"></param>
    public static void RemoveMoney(double charge)
    {
       if(charge > money)
        {
            //go into debt?
        }
        else
        {
            money -= charge;
        }
    }
    /// <summary>
    /// add moneys to the player balance
    /// </summary>
    /// <param name="deposit"></param>
    public static void AddMoney(double deposit)
    {
        money += deposit;
    }  
    /// <summary>
    /// finds the current money the player has
    /// </summary>
    /// 
    /// <returns>amount of money player has </returns>
    /// 
    public static double GetMoneyAmount()
    {
        return money;
    }

    #endregion

    #region ProfitCalculations
    private static void CalculateAllProfits()
    {

        //multithreaded?
        

    }
    public static void CalculateAllProfits_()
    {

       // List<ICalculateProfits> builtAssets = BuiltAssets.GetBuildAssets() as List<ICalculateProfits>;
        List<IAsset> builtAssets = BuiltAssets.GetBuildAssets();
      

        foreach (IAsset item in builtAssets)
        {

           float profits =  item.GetProfits();
            AddMoney(profits); 
        }
       
       

    }
 
    #endregion
}

