using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using System.Linq;
using AssetInformation;

public class BuildingInfoScreen : MonoBehaviour
{
    [SerializeField] GameObject buildingInfoPanel;
    [SerializeField] GameObject buildingButtonPanel;

    [SerializeField] TextMeshProUGUI infoText;


    private List<Type> buildingTypes = new();

    string price;

   public enum BuildingTypes
    {
        Lemonade_Stand,
        Bakery


    }

    private void Awake()
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


               

                buildingTypes.Add(item);

                //can use the theTypes var to see what is in the thing
            }

        }
    }


    private void Start()
    {
        
        buildingInfoPanel.SetActive(false);
        SetInfoText();
    }
    public void CloseBuildingInfo()
    {
        buildingInfoPanel.SetActive(false);
        print("deactived");
    }
    public void SetBuildingInfo()
    {
        buildingInfoPanel.SetActive(true);
        //some sort of animation to make it like purrty
        print("activated");


        SetInfoText();




    }
 
    public void Buy(string buildingType)
    {
       // BuildingTypes buildingType = 0;

        Lemonade_Stand.Buy();

        SetInfoText();




        // && item.ToString() == buildingType.ToString()

        foreach (var item in buildingTypes)
        {

            if(item.ToString() == buildingType)
            {
                var methodToCall = item.GetMethod("Buy");

                // var anotherThing = item.GetInterface("ICalculateProfits");

                methodToCall.Invoke(item.GetType(), null);
            }



        }
       




    }
    void SetInfoText()
    {
        price = Lemonade_Stand.currentPrice.ToString("0.00");
        infoText.text = $"Price: {price}\nAmount: {Lemonade_Stand.assetAmount}\n";
    }
    private void ActivateBuildingInfo()
    {
        //eventually play animation to make it look like but not now





      
    }





}