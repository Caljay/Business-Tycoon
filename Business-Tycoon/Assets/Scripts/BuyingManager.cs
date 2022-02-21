using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AssetInformation;
using System;

public class BuyingManager : MonoBehaviour
{
    List<Type> buyableAssets = new();
        void Start()
    {
       buyableAssets = AssetInformation.AssetInfo.GetAllAssetTypesAsList();
    }

    public void BuyAsset(string assetName)
    {
        foreach (var item in buyableAssets)
        {
            if(item.Name == assetName)
            {
                var methodRef = item.GetMethod("Buy");
                
                if ((bool)methodRef.Invoke(item.GetType(), null))
                {
                    FindObjectOfType<HoverScreen>().SetAllInfo();
                    return;
                }

            }
        }


        
    }
}
