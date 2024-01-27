using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

/// <summary>
/// 游戏关卡配置数据
/// </summary>
public class GameData
{
    public static int[,] level1InitMapTypeData = new int[5, 5]
    {
    { 1, 1, 1, 1, 1 },
    { 1, 1, 1, 1, 1 },
    { 1, 1, 1, 1, 1 },
    { 1, 1, 1, 1, 1 },
    { 1, 1, 1, 1, 1 }
    };

    public static int[,] level1InitMapData = new int[5, 5]
    {
    { 1, 1, 1, 1, 1 },
    { 1, 1, 1, 1, 1 },
    { 1, 1, 1, 1, 1 },
    { 1, 1, 1, 1, 1 },
    { 1, 1, 1, 1, 1 }
    };

    public static int[,] level1EndMapData = new int[5, 5]
    {
    { 1, 1, 1, 1, 1 },
    { 1, 1, 1, 1, 1 },
    { 1, 1, 1, 1, 1 },
    { 1, 1, 1, 1, 1 },
    { 1, 1, 1, 1, 1 }
    };

    public static int GetSmallTypeDefaultValue(int bigTileType)
    {
        switch ((BigTileType)bigTileType)
        {
            case BigTileType.HalfRingType:
                return (int)HalfRingType.Left;
            default:
                return (int)BigTileType.None;
        }
    }
}

public enum BigTileType
{
    None = 0,
    HalfRingType = 1
}

public enum HalfRingType
{
    Left = 1,
    Right = 2,
    Top = 3,
    Bottom = 4,
    Length = 5
}