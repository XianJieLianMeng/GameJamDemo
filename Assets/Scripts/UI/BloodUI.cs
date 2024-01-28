using System;
using System.Collections;
using System.Collections.Generic;
using UniFramework.Event;
using UnityEngine;
using static EventDefine;

public class BloodUI : MonoBehaviour
{
    [SerializeField]
    private List<Transform> bloodItemList = new List<Transform>();

    // Start is called before the first frame update
    private void Start()
    {
        UniEvent.AddListener<EventDefine.EventBloodUpdate>(OnEventBloodUpdate);
    }

    private void OnDestroy()
    {
        UniEvent.RemoveListener<EventDefine.EventBloodUpdate>(OnEventBloodUpdate);
    }

    private void OnEventBloodUpdate(IEventMessage message)
    {
        if(message is EventDefine.EventBloodUpdate bloodMsg)
        {
            UpdateBlood(bloodMsg.Count);
        }
    }

    private void UpdateBlood(int count)
    {
        //int maxVisibleIndex = count; // 最后一个需要隐藏的血条索引

        for (int i = 0; i < bloodItemList.Count; i++)
        {
            if (i <= count-1)
            {
                bloodItemList[i].gameObject.SetActive(true); // 显示血条
            }
            else
            {
                bloodItemList[i].gameObject.SetActive(false); // 隐藏血条
            }
        }
    }
}
