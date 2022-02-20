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



       
    }

    public void Enter(string name)
    {
        print("entered");
        assetName = name;
       
        Vector3 mousePos = Input.mousePosition;
        mousePos.y += 50f;
        hoverPanel.transform.position = mousePos;

        hoverPanel.SetActive(true);

        SetAllInfo();
    }
    public void Exit()
    {
        print("exited");
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


/* THINGS TO DISPLAY
 


  public static int assetAmount;
    public static double currentPrice = 2;
    public static float profit = 5f;
    public static float costs = 3f;

 */