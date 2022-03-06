using UnityEngine;
using AssetInformation;


public class BuildingPoint : MonoBehaviour
{
   
    //actual businesess
     public IAsset asset { get; private set; } = null;
    public bool isAvalible = false;

 
    private void Start()
    {

        GetComponent<SpriteRenderer>().color = Color.blue;

        if(asset != null)
        {
            isAvalible = false;
        }
        else isAvalible = true;
        

    }
public void Build(IAsset building)
    {
        asset = building;
        Debug.Log(asset.GetProfits());
        Debug.Log($"Built an asset of type {building}");
        isAvalible = false;
       
        
     
    }

  public void Demolish()
    {
        asset = null;
        isAvalible = true;
    }




}
