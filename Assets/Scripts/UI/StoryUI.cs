using System;
using System.Collections;
using System.Collections.Generic;
using UniFramework.Event;
using UnityEngine;
using UnityEngine.UI;
using static EventDefine;

public class StoryUI : MonoBehaviour
{
    [SerializeField]
    private Text storyText;

    private void Start()
    {
        UniEvent.AddListener<EventDefine.EventBloodUpdate>(OnEventBloodUpdate);
    }

    private void OnEventBloodUpdate(IEventMessage message)
    {
        if (message is EventDefine.EventBloodUpdate bloodMsg)
        {
            storyText.text = "";
        }
    }

    private void OnDestroy()
    {
        UniEvent.RemoveListener<EventDefine.EventBloodUpdate>(OnEventBloodUpdate);
    }

}
