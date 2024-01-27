using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Tile : MonoBehaviour,IPointerDownHandler
{

    public RectTransform rectTransform;

    //判断动画是否结束
    private bool flag = true;
    private int value;
    private int x, y;
    /// <summary>
    /// 根据类型值设置旋转角度
    /// </summary>
    /// <param name="value"></param>
    public void Init(int x,int y,int value)
    {
        //根据类型
        this.value = value;
        this.x = x;
        this.y = y;
    }

    private void RotateTile()
    {
        flag = false;
        //实现旋转逻辑
        var rotation = rectTransform.rotation.eulerAngles;
        var vector3 = new Vector3(rotation.x,rotation.y,rotation.z-90f);
        rectTransform.DOLocalRotate(vector3,0.5f).OnComplete(() => { flag = true;});
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

    public void OnPointerDown(PointerEventData eventData)
    {
        if (!flag)
        {
            return;
        }
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
