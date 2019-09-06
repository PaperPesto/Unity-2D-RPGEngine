using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarComponent : MonoBehaviour
{
    public int ActualHealth;
    public int MaxHealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float scale = (float)ActualHealth / (float)MaxHealth;

        if(scale >= 0 && scale <= 1)
        {
            //Debug.Log("scale" + scale);
            gameObject.transform.GetChild(1).transform.localScale = new Vector3(scale, 1);
        }
    }
}
