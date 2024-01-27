using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class Chessboard : MonoBehaviour
{

    [SerializeField] private GameObject tilePrefab;
    [SerializeField] private List<Sprite> leveOne;
    [SerializeField] private List<Sprite> leveTwo;
    [SerializeField] private List<Sprite> leveThree;
    [SerializeField] private Transform cam;
    
    public void Init()
    {
        InitializeChessboard(LevelManager.Instance.MapData);
    }

    private void InitializeChessboard(int[,] mapData)
    {
        int width = mapData.GetLength(0);
        int height = mapData.GetLength(1);
        int index = 0;
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                // Vector3 position = new Vector3(i, j, 0);
                Vector3 position = new Vector3(j-2,height -i -2, 0);
                //GameObject go = TileManager.Instance.InstiateTile(mapData[i,j],position,Quaternion.identity);
                GameObject go = Instantiate(tilePrefab, position, Quaternion.identity);
                go.name = $"Tile {i} {j}";
                go.transform.parent = transform;
                go.transform.localScale = Vector3.one;
                var tile = go.GetComponent<Tile>();
                tile.Init(i,j,mapData[i, j]);
                if (LevelManager.Instance.Level == 1)
                {
                    go.GetComponent<Image>().sprite = leveOne[index];
                }else if (LevelManager.Instance.Level == 2)
                {
                    
                }
                else
                {
                    
                }

                index++;
            }
        }
    }
}