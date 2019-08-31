using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualPosition : MonoBehaviour
{
    public int Virtual_x;
    public int Virtual_y;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StepUP_X()
    {
        Virtual_x++;
    }

    public void StepDOWN_X()
    {
        Virtual_x--;
    }

    public void StepUP_Y()
    {
        Virtual_y++;
    }

    public void StepDOWN_Y()
    {
        Virtual_y--;
    }

    public void UpdatePositionInt(int x, int y)
    {
        transform.position = new Vector3(x + 0.5f, y + 0.5f, 0);
    }

    public void UpdatePositionFloat(Vector3 floatposition)
    {
        int x = Mathf.FloorToInt(floatposition.x);
        int y = Mathf.FloorToInt(floatposition.y);

        UpdatePositionInt(x, y);
    }

    // Update is called once per frame
    void Update()
    {
        //int x = Mathf.FloorToInt(Virtual_x);
        //int y = Mathf.FloorToInt(Virtual_y);

        //transform.position = new Vector3(x + 0.5f, y + 0.5f, 0);
    }
}
