using System;


namespace AssetInformation
{
    public interface ICalculateProfits
    {
        public static void SendProfits()
        {
            throw new NotImplementedException();
        }
    }
    public interface IAsset
    {
        public static int assetAmount;
        public static double currentPrice;
        public static float profit;
        public static float costs;

        static float multiplier;

        public static void Buy() { }
        public static void CalculateNewPrices() { currentPrice = currentPrice * (System.Math.Pow(multiplier, assetAmount)); }


    }
    public class AssetInfo
    {
      




    }




}

