using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using AssetInformation;
using TMPro;

public class HoverScreen : MonoBehaviour
{

    [SerializeField] GameObject hoverPanel;
    [SerializeField] TextMeshProUGUI infoText;

    List<Type> buildingTypes = new();
    string assetName = null;

    private void Awake()
    {
        hoverPanel.SetActive(false);

        
    }
    private void Start()
    {

        buildingTypes = AssetInformation.AssetInfo.GetAllAssetTypesAsList();

       
    }

    public void Enter(string name)
    {

        assetName = name;
       
      

        hoverPanel.SetActive(true);

        SetAllInfo();
    }
    public void Exit()
    {
       
        assetName = null;
        hoverPanel.SetActive(false);
    }
    public void SetAllInfo()
    {

        int assetAmount = 0;
        double price = 0D;
        float profits = 0f;
        float costs = 0f; 

        foreach (var item in buildingTypes)
        {

            if(assetName == item.Name)
            {

                var assetAmnt = item.GetField("assetAmount");
                var thePrice = item.GetField("currentPrice");
                var theProfits = item.GetField("profit");
                var theCosts = item.GetField("costs");


                assetAmount = (int)assetAmnt.GetValue(null);
                price = (double)thePrice.GetValue(null);
                profits = (float)theProfits.GetValue(null);
                costs = (float)theCosts.GetValue(null);



                  

            }


        }



        infoText.text = $"Amount: {assetAmount}\nPrice: {price}\nProfits: {profits}\nCosts: {costs}";




    }
}