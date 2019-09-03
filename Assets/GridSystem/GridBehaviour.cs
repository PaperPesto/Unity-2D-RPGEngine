using UnityEngine;

public class GridBehaviour : MonoBehaviour
{
    public int Rows = 10;
    public int Columns = 10;
    public int Scale = 1;
    public Vector2Int StartingGrid;
    public GameObject GrassTile;
    public GameObject EarthTile;

    // Start is called before the first frame update
    void Start()
    {
        GenerateGrid();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void GenerateGrid()
    {
        for (int i = -Rows/2; i < Rows/2; i++)
        {
            for (int j = -Columns/2; j < Columns/2; j++)
            {
                GameObject obj = Instantiate(GrassTile, new Vector3(0.0f + i * Scale, 0.0f + j * Scale, 0.0f), new Quaternion()); // rimasto al riempimento della griglia con gli oggetti
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawSphere(new Vector3(StartingGrid.x, StartingGrid.y, 0), 0.1f);
    }
}
