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

    public static int[,] level1ModData = new int[5, 5]
    {
        { 4, 4, 4, 2, 4 },
        { 2, 2, 4, 2, 4 },
        { 4, 4, 4, 4, 4 },
        { 4, 2, 4, 2, 4 },
        { 4, 2, 4, 4, 4 }
    };
    
    public static int[,] level1EndMapData = new int[5, 5]
    {
    { 3, 2, 0, 1, 3 },
    { 0, 0, 0, 1, 1 },
    { 0, 2, 4, 2, 0 },
    { 3, 1, 3, 1, 0 },
    { 2, 1, 1, 1, 3 }
    };
}

public class GameDefine
{
    public const int AlwaysPassword = 4;
}

public enum HalfRingType
{
    Left = 1,
    Right = 2,
    Top = 3,
    Bottom = 4,
    Length = 5
}