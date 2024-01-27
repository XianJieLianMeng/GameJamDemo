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
    private int[,] mapTypeData;
    public int[,] MapTypeData => mapTypeData;
    private int[,] mapData;
    public int[,] MapData => mapData;
    private int[,] endMapData;
    private int level;
    public int Level => level;

    public void InitLevel(int[,] mapData, int[,] endMapData,int level)
    {
        this.mapData = mapData;
        this.endMapData = endMapData;
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
        smallType += 1;
        var nextValue = smallType % (int)HalfRingType.Length != 0 ? smallType % (int)HalfRingType.Length : smallType % (int)HalfRingType.Length + 1;

        mapData[x, y] = nextValue;

        if (mapData.AreArraysEqual(endMapData))
        {
            Debug.LogError("GameOver");
        }
    }
}
        