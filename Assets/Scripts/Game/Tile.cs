using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Tile : MonoBehaviour, IPointerDownHandler
{
    /// <summary>
    /// 处理鼠标按下
    /// </summary>
    /// <param name="eventData"></param> <summary>
    /// 
    /// </summary>
    /// <param name="eventData"></param>
    public void OnPointerDown(PointerEventData eventData)
    {
        // 在这里编写处理点击事件的代码
        Debug.Log("Tile was clicked!");
        //每次旋转自身 TODO
        //旋转完写入当前关卡数据 TODO
        //判断是否满足通关条件 TODO
    }
}