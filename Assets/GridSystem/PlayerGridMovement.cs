using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGridMovement : MonoBehaviour
{
    public void OnMouseDrag()
    {
        Debug.Log("drag " + gameObject.name);

        var pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if(gameObject.name == "Player1")
        {
            //gameObject.transform.position = pos;
            GameObject.Find("GridGenerator").GetComponent<GridBehaviour>().MovePlayer1(new Vector2Int(Mathf.FloorToInt(pos.x), Mathf.FloorToInt(pos.y)));
        } else if (gameObject.name == "Player2")
        {
            GameObject.Find("GridGenerator").GetComponent<GridBehaviour>().MovePlayer2(new Vector2Int(Mathf.FloorToInt(pos.x), Mathf.FloorToInt(pos.y)));
        }
    }

    public void OnMouseEnter()
    {
        Debug.Log("Mouse enter on " + gameObject.name);
    }

    public void OnMouseExit()
    {
        Debug.Log("Mouse exit from " + gameObject.name);
    }
}
