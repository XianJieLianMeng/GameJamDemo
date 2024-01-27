using UnityEngine;
using UnityEngine.EventSystems;

public class Chessboard : MonoBehaviour
{

    [SerializeField] private GameObject tilePrefab;
    [SerializeField] private Transform cam;
    private void Start()
    {
        InitializeChessboard(GameData.level1MapData);
    }

    private void InitializeChessboard(int[,] mapData)
    {
        for (int i = 0; i < mapData.GetLength(0); i++)
        {
            for (int j = 0; j < mapData.GetLength(1); j++)
            {
                Vector3 position = new Vector3(i, j, 0);
                //GameObject go = TileManager.Instance.InstiateTile(mapData[i,j],position,Quaternion.identity);
                GameObject go = Instantiate(tilePrefab, position, Quaternion.identity);
                go.name = $"Tile {i} {j}";
                go.transform.parent = transform;
                go.transform.localScale = Vector3.one;
                var tile = go.GetComponent<Tile>();
                //if (mapData[i][j] != 0)
                //{  
                //    初始化元素 TODO
                //   //FlowManager.Instance.PlaceHead(Colors.ColorOrder[currentLevel[x][y] - 1], x, y);
                //}
            }
        }

        cam.transform.position = new Vector3((float)mapData.GetLength(0) / 2 - .5f, (float)mapData.GetLength(1) / 2 - .5f, -10);
    }
}