using System;

public static class MoneyManager 
{
    private static double money = 100;


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

    public static void CalculateAllProfits()
    {

    }
}

