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

    public static int[,] level2InitMapData = new int[5, 5]
    {
    { 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0 }
    };

    public static int[,] level2ModData = new int[5, 5]
    {
        { 4, 4, 4, 2, 4 },
        { 2, 2, 4, 2, 4 },
        { 4, 4, 4, 4, 4 },
        { 4, 2, 4, 2, 4 },
        { 4, 2, 4, 4, 4 }
    };

    public static int[,] level2EndMapData = new int[5, 5]
    {
    { 3, 2, 0, 1, 3 },
    { 0, 0, 0, 1, 1 },
    { 0, 2, 4, 2, 0 },
    { 3, 1, 3, 1, 0 },
    { 2, 1, 1, 1, 3 }
    };

    public static int[,] level3InitMapData = new int[5, 5]
    {
    { 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0 }
    };

    public static int[,] level3ModData = new int[5, 5]
    {
        { 4, 4, 4, 2, 4 },
        { 2, 2, 4, 2, 4 },
        { 4, 4, 4, 4, 4 },
        { 4, 2, 4, 2, 4 },
        { 4, 2, 4, 4, 4 }
    };

    public static int[,] level3EndMapData = new int[5, 5]
    {
    { 3, 2, 0, 1, 3 },
    { 0, 0, 0, 1, 1 },
    { 0, 2, 4, 2, 0 },
    { 3, 1, 3, 1, 0 },
    { 2, 1, 1, 1, 3 }
    };

    public static int[,] level4InitMapData = new int[5, 5]
   {
    { 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0 }
   };

    public static int[,] level4ModData = new int[5, 5]
    {
        { 4, 4, 4, 2, 4 },
        { 2, 2, 4, 2, 4 },
        { 4, 4, 4, 4, 4 },
        { 4, 2, 4, 2, 4 },
        { 4, 2, 4, 4, 4 }
    };

    public static int[,] level4EndMapData = new int[5, 5]
    {
    { 3, 2, 0, 1, 3 },
    { 0, 0, 0, 1, 1 },
    { 0, 2, 4, 2, 0 },
    { 3, 1, 3, 1, 0 },
    { 2, 1, 1, 1, 3 }
    };


    public static int[,] GetInitMapData(int level)
    {
        if(level == 0)
        {
            return level1InitMapData;
        }
        else if(level == 1)
        {
            return level2InitMapData;
        }
        else if(level == 2)
        {
            return level3InitMapData;
        }
        else 
        {
            return level4InitMapData;
        }
    }

    public static int[,] GetEndMapData(int level)
    {
        if (level == 0)
        {
            return level1EndMapData;
        }
        else if (level == 1)
        {
            return level2EndMapData;
        }
        else if (level == 2)
        {
            return level3EndMapData;
        }
        else 
        {
            return level4EndMapData;
        }
    }

    public static int[,] GetModData(int level)
    {
        if (level == 0)
        {
            return level1ModData;
        }
        else if (level == 1)
        {
            return level2ModData;
        }
        else if (level == 2)
        {
            return level3ModData;
        }
        else
        {
            return level4ModData;
        }
    }
}

public class GameDefine
{
    public const int AlwaysPassword = 4;
    public const int MaxLevel = 4;
}

public enum HalfRingType
{
    Left = 1,
    Right = 2,
    Top = 3,
    Bottom = 4,
    Length = 5
}