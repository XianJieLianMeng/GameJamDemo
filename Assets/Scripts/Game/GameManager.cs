using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Chessboard chessboard;
 
    void Start()
    {
        var level = PlayerPrefs.GetInt("Level");

        if (level >= 0 && level < GameDefine.MaxLevel)
        {
            int[,] initMapData = GameData.GetInitMapData(level);
            int[,] endMapData = GameData.GetEndMapData(level);
            int[,] modData = GameData.GetModData(level);

            LevelManager.Instance.InitLevel(initMapData, endMapData, modData, level);
        }
        else
        {
            // 处理无效的关卡索引
            Debug.LogError("Invalid level index: " + level);
        }
        chessboard.Init();
    }
}
