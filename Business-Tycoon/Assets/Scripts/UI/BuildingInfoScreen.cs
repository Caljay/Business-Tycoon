using UnityEngine;

public class BuildingInfoScreen : MonoBehaviour
{
    [SerializeField] GameObject buildingInfoPanel;
  
    private void Start()
    {
        
        buildingInfoPanel.SetActive(false);
    }

    public void CloseBuildingInfo()
    {
        buildingInfoPanel.SetActive(false);
      
    }
    public void SetBuildingInfo()
    {
        buildingInfoPanel.SetActive(true);
        //some sort of animation to make it like purrty

    }

}