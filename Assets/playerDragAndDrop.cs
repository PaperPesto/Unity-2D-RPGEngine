using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class playerDragAndDrop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDrag()
    {
        Debug.Log("drag");

        var pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        GetComponent<VirtualPosition>().UpdatePositionFloat(pos);

        Vector2 absolutemovement = transform.position - transform.GetChild(0).transform.position;
        transform.GetChild(0).transform.position = absolutemovement;
    }
}
