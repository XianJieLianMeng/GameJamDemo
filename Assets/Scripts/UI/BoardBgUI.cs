using System;
using System.Collections;
using System.Collections.Generic;
using UniFramework.Event;
using UnityEngine;
using static EventDefine;

public class BoardBgUI : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> bgList = new List<GameObject>();

    void Start()
    {
        UniEvent.AddListener<EventDefine.EventGameStartLevel>(OnEventGameStartLevel);
    }

    private void OnDestroy()
    {
        UniEvent.RemoveListener<EventDefine.EventGameStartLevel>(OnEventGameStartLevel);
    }

    private void OnEventGameStartLevel(IEventMessage message)
    {
        if(message is EventGameStartLevel startLevelMsg)
        {
            ChangeBg(startLevelMsg.Level);
        }
    }

    private void ChangeBg(int level)
    {
        for(int i=0;i<bgList.Count;i++)
        {
            if(level == i)
            {
                bgList[i].SetActive(true);
            }
            else
            {
                bgList[i].SetActive(false);
            }
        }
       
    }
}
