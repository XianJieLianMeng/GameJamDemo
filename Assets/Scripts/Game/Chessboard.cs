using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class Chessboard : MonoBehaviour
{

    [SerializeField] private GameObject tilePrefab;
    [SerializeField] private Transform cam;

    public void Init()
    {
        InitializeChessboard(LevelManager.Instance.MapTypeData,LevelManager.Instance.MapData);
    }

    private void InitializeChessboard(int[,] mapTypeData,int[,] mapData)
    {
        int width = mapTypeData.GetLength(0);
        int height = mapTypeData.GetLength(1);
        int[,] levelData = new int[width,height];
        for (int i = 0; i < mapTypeData.GetLength(0); i++)
        {
            for (int j = 0; j < mapTypeData.GetLength(1); j++)
            {
                Vector3 position = new Vector3(i, j, 0);
                //GameObject go = TileManager.Instance.InstiateTile(mapData[i,j],position,Quaternion.identity);
                GameObject go = Instantiate(tilePrefab, position, Quaternion.identity);
                go.name = $"Tile {i} {j}";
                go.transform.parent = transform;
                go.transform.localScale = Vector3.one;
                var tile = go.GetComponent<Tile>();
                tile.Init(i,j,mapTypeData[i,j],mapData[i, j]);
            }
        }

        cam.transform.position = new Vector3((float)mapData.GetLength(0) / 2 - .5f, (float)mapData.GetLength(1) / 2 - .5f, -10);
    }
}