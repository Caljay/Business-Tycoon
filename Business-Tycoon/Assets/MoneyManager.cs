using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

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


        var type = typeof(ICalculateProfits);

        var types = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(s => s.GetTypes())
            .Where(p => type.IsAssignableFrom(p) && p.IsClass && !p.IsInterface);

        List<Type> theTypes = new();

        foreach (var item in types)
        {
            if (!item.IsInterface)
            {
                theTypes.Add(item);

                var something = item.GetMethod("SendProfits");

                // var anotherThing = item.GetInterface("ICalculateProfits");

                something.Invoke(type.GetType(), null);

                theTypes.Add(item);

                //can use the theTypes var to see what is in the thing
            }

        }
       


    }



    public interface ICalculateProfits
    {
       public static void SendProfits()
        {
            throw new NotImplementedException();
        }
    }

}

