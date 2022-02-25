using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AssetInformation;

public class BuildingPoint : MonoBehaviour
{
     IAsset asset = null;

    private void Start()
    {
    
    }
    private void OnMouseDown()
    {
        if (asset == null)
        {

            asset = new Lemonade_Stand();
            Debug.Log("built");
        }
       else
        {
            BuiltAssets.RemoveAsset(asset);
            asset = null;
            Debug.Log("removed");
               
        }



    }

    private void OnMouseOver()
    {


        
        //will affect supply/demand with its certain traits

    }

    
}
