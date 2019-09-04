using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FocusTile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        Debug.Log("onMouseOver" + gameObject.name);
        //gameObject.GetComponent<Outline>().enabled = true;
    }

    private void OnMouseExit()
    {
        Debug.Log("onMouseExit" + gameObject.name);
        //gameObject.GetComponent<Outline>().enabled = false;
    }
}
