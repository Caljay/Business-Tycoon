using System;
using System.Collections.Generic;
using System.Linq;

namespace AssetInformation
{
    public interface ICalculateProfits
    {
        public void SendProfits()
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

        public static bool Buy() { return true; }
        public static void SendProfits() { }


    }
  
    public static class AssetInfo
    {

       static List<Type> buildingTypes = new();

        public static List<Type> GetAllAssetTypesAsList()
        {




            var type = typeof(ICalculateProfits);

            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && p.IsClass && !p.IsInterface);

            foreach (var item in types)
            {
                if (!item.IsInterface)
                {

                    buildingTypes.Add(item);


                }

            }
            return buildingTypes;



        }



    }

   
    public static class BuiltAssets
    {
        static List<IAsset> allBuiltAssets = new List<IAsset>();
        public static void AddAsset(IAsset newAsset)
        {

            allBuiltAssets.Add(newAsset);
        
        }
        public static void RemoveAsset(IAsset removeAsset)
        {
            allBuiltAssets.Remove(removeAsset);
        }

       public static List<IAsset> GetBuildAssets()
        {
            return allBuiltAssets;
        }

    }


}

