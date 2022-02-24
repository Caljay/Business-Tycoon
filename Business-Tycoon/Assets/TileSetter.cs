using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileSetter : MonoBehaviour
{
    [SerializeField] Tilemap tilemap;
    [SerializeField] Tile tile;
    [SerializeField] GameObject lemonade;
    Tilemap tm;
    Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        tm = tilemap.GetComponent<Tilemap>();
        cam = Camera.main;
        
       
    }

    // Update is called once per frame
    void Update()
    {
      // CheckForHover();
        if (Input.GetMouseButtonDown(0))
        {
            var mousePos = Input.mousePosition;


            var changedPos = cam.ScreenToWorldPoint(mousePos);

           
           // Vector3Int tilePos = new Vector3Int(Mathf.RoundToInt(changedPos.x), Mathf.RoundToInt(changedPos.y), Mathf.RoundToInt(changedPos.z));
            var cellPos = tm.WorldToCell(changedPos);

            if(!tm.HasTile(cellPos))
            {
                tm.SetTile(cellPos, tile);

                
                Vector3 assetPlace = tm.CellToWorld(cellPos);
                assetPlace.x += 0.5f;
                assetPlace.y += 0.5f;
                assetPlace.z = -1;
                
                Instantiate(lemonade, assetPlace, Quaternion.identity);

            }
            print(tm.size);
        }
       
    }
    void CheckForHover()
    {
        var mousePos = Input.mousePosition;


        var changedPos = cam.ScreenToWorldPoint(mousePos);


        // Vector3Int tilePos = new Vector3Int(Mathf.RoundToInt(changedPos.x), Mathf.RoundToInt(changedPos.y), Mathf.RoundToInt(changedPos.z));
        var cellPos = tm.WorldToCell(changedPos);

        if (tm.HasTile(cellPos))
        {
           
            print("hovering over tile");
            
         
        }



    }
}
