using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 处理每一关的数据
/// </summary> <summary>
/// 
/// </summary>
public class LevelManager :Singleton<LevelManager>
{
    private int[,] mapData;
    public int[,] MapData => mapData;
    private int[,] endMapData;
    public int[,] EndMapData => endMapData;
    private int[,] mapModData;
    public int[,] MapModData => mapModData;
    private int level;
    public int Level => level;

    public void InitLevel(int[,] mapData, int[,] endMapData,int[,] mapModData,int level)
    {
        this.mapData = mapData;
        this.endMapData = endMapData;
        this.mapModData = mapModData;
        this.level = level;
    }

    /// <summary>
    /// 更新数据，判断游戏是否结束
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="bigType"></param>
    /// <param name="smallType"></param>
    public void UpdateMapData(int x,int y,int smallType)
    {
        mapData[x, y] = smallType % mapModData[x, y];

        if (mapData.IsPasswordCorrect(endMapData))
        {
            Debug.LogError("GameOver");
        }
    }
}
        