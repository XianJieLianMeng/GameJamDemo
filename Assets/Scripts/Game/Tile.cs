using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Tile : MonoBehaviour
{

    private void RotateTile()
    {
        // 编写旋转自身的代码
        // TODO: 实现旋转逻辑
    }

    private void SaveLevelData()
    {
        // 编写写入当前关卡数据的代码
        // TODO: 实现写入数据逻辑
    }

    private void CheckWinCondition()
    {
        // 编写判断通关条件的代码
        // TODO: 实现判断通关条件的逻辑
    }

    private void OnMouseDown()
    {
        // 在这里编写处理点击事件的代码
        Debug.Log("Tile was clicked!");

        // 旋转自身
        RotateTile();

        // 写入当前关卡数据
        SaveLevelData();

        // 判断是否满足通关条件
        CheckWinCondition();
    }
}
