using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class tileMapAgent : MonoBehaviour
{
    public Tilemap Tilemap;
    //TileBase
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var mouseinput = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        int x = Mathf.FloorToInt(mouseinput.x);
        int y = Mathf.FloorToInt(mouseinput.y);
        int z = Mathf.FloorToInt(mouseinput.z);

        var focustile = Tilemap.GetTile(new Vector3Int(x, y, z));

        //focustile. Rimane da focusare la tile quando ci focussi sopra con iol mouse
    }
}
