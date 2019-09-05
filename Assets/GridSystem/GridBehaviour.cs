using UnityEngine;

public class GridBehaviour : MonoBehaviour
{
    public int Rows = 10;
    public int Columns = 10;
    public int Scale = 1;
    public Vector2Int StartingGrid;
    public GameObject GrassTile;
    public GameObject EarthTile;

    // Gestione giocatori
    public GameObject Player1;
    public Vector2Int Player1Pos;
    public GameObject Player2;
    public Vector2Int Player2Pos;

    // Start is called before the first frame update
    void Start()
    {
        GenerateGrid();
        MovePlayers();
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
                obj.name = string.Format("tile_{0}_{1}", i, j);
                obj.transform.SetParent(gameObject.transform);
            }
        }
    }

    void MovePlayers()
    {
        Player1.transform.position = new Vector3(Player1Pos.x, Player1Pos.y, 0);
        Player2.transform.position = new Vector3(Player2Pos.x, Player2Pos.y, 0);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawSphere(new Vector3(StartingGrid.x, StartingGrid.y, 0), 0.1f);
    }

    public void MovePlayer1(Vector2Int newpos)
    {
        Player1Pos = newpos;
        MovePlayers();
    }

    public void MovePlayer2(Vector2Int newpos)
    {
        Player2Pos = newpos;
        MovePlayers();
    }
}
