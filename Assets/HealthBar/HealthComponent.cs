using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    public int ActualHealth = 10;
    public int MaxHealth = 10;

    public int xe;
    public int ye;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float scale = (float)ActualHealth / (float)MaxHealth;
        transform.GetChild(0).transform.localScale = new Vector2(10 * scale, 1);
        transform.GetChild(0).transform.localPosition = new Vector2(0, -8);
    }
}
