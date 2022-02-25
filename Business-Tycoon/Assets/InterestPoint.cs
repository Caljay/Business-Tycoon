using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterestPoint : MonoBehaviour
{

    [SerializeField] Sprite pointSprite;
    [SerializeField] GameObject hoverPanel;

    // Start is called before the first frame update
    void Start()
    {
        hoverPanel.SetActive(false); 
    }

    private void OnMouseOver()
    {

     
        print("mouse over POI; display info");
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        hoverPanel.transform.position = new Vector3(50 + mousePos.x, mousePos.y, 0);
        
        hoverPanel.SetActive(true);
        //will affect supply/demand with its certain traits

    }
    private void OnMouseExit()
    {
        hoverPanel.SetActive(false);
    }
}
