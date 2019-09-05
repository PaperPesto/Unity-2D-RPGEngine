using UnityEngine;

public class HealthBarScript : MonoBehaviour
{
    public int PercHealth;
    public Vector2 BarPosition = new Vector2(-0.5f, -0.5f);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.GetChild(1).transform.position = BarPosition;
    }

    //public void Add(int health)
    //{
    //    Health = Health + health;
    //}

    //public void Remove(int health)
    //{
    //    Health = Health - health;
    //}

    void UpdateHealthBar()
    {
        transform.GetChild(1).transform.position = new Vector3();
    }
}
