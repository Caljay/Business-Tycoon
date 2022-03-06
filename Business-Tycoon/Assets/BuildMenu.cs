using AssetInformation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//opens the building menu
//allows building of assets
//display info about building before built
public class BuildMenu : MonoBehaviour
{
    [SerializeField] bool isBuilding = false;
    [SerializeField] GameObject buildMenu;
    IAsset buildingHolder;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.B) && !isBuilding)
        {
            isBuilding = true;
            buildMenu.SetActive(true);
            //open building menu
        }
        else if(Input.GetKeyDown(KeyCode.B) && isBuilding)
        {
            isBuilding = false;
            buildMenu.SetActive(false);
        }
       
        if(isBuilding && buildMenu.activeSelf == false)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                FindBuildingPoint();

            }



        }
    }
    private  void FindBuildingPoint()
    {
        //check
        Vector3 worldSpace = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldSpace.z = 1;
        Ray rayCast = new Ray(worldSpace, Vector3.back);
        Debug.Log(rayCast);

        RaycastHit hit;
        Physics.Raycast(rayCast, out hit, 25);

        if(hit.collider.gameObject.tag == "BuildingPoint")
        {
            GameObject buildingPoint = hit.collider.gameObject;
            var BP = buildingPoint.GetComponent<BuildingPoint>();

            if (buildingHolder != null)
            {
                BP.Build(buildingHolder);

                buildingHolder = null;
                isBuilding = false;
                buildMenu.SetActive(false);
            }

        }

    }


    private void SetBuildLocations()
    {
        buildMenu.SetActive(false);
    }

public void Lemondade() 
    {
        buildingHolder = new Lemonade_Stand();
        SetBuildLocations();
        //need a way to check

    }
public void Bakery() 
    {

    }

    
}
