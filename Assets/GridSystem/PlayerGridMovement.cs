using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGridMovement : MonoBehaviour
{
    public void OnMouseDrag()
    {
        Debug.Log("drag");

        var pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        GameObject.Find("GridGenerator").GetComponent<GridBehaviour>().MovePlayer1(new Vector2Int(Mathf.FloorToInt(pos.x), Mathf.FloorToInt(pos.y)));
    }
}
