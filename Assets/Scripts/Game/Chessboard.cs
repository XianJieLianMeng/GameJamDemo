using UnityEngine;

public class Chessboard : MonoBehaviour
{
    public int width;
    public int height;
    [SerializeField]
    public GameObject tilePrefab;

    private void Start()
    {
        InitializeChessboard();
    }

    private void InitializeChessboard()
    {
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                Vector3 position = new Vector3(i, j, 0);
                GameObject tile = Instantiate(tilePrefab, position, Quaternion.identity);
                tile.transform.parent = transform;
            }
        }
    }
}