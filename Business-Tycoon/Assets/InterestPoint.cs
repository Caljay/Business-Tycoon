using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterestPoint : MonoBehaviour
{
    //cities and such

    //[SerializeField] Sprite pointSprite;
    [SerializeField] GameObject hoverPanel;

    // Start is called before the first frame update
    void Start()
    {
        hoverPanel.SetActive(false); 
    }

    private void OnMouseOver()
    {
        GetComponent<SpriteRenderer>().color = Color.green;
     
        if (Input.GetMouseButtonDown(0))
        {
            hoverPanel.SetActive(true);
            
        }
        //will affect supply/demand with its certain traits

    }
   
    private void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().color = Color.white;

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Escape))
            {
            hoverPanel.SetActive(false);

        }

    }
}
