using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

/// <summary>
/// 游戏关卡配置数据
/// </summary>
public class GameData
{
    public static int[,] level1InitMapData = new int[5, 5]
    {
    { 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0 }
    };

    public static int[,] level1EndMapData = new int[5, 5]
    {
    { 3, 2, 0, 3, 3 },
    { 2, 0, 0, 3, 1 },
    { 0, 2, 0, 2, 0 },
    { 3, 1, 3, 1, 0 },
    { 2, 1, 1, 1, 3 }
    };
}

public enum HalfRingType
{
    Left = 1,
    Right = 2,
    Top = 3,
    Bottom = 4,
    Length = 5
}