using System;
using System.Collections;
using System.Collections.Generic;
using Game;
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
            if(LevelManager.Instance.Level == 0)
            {
                storyText.text =  DialogManager.GetDuYanErrorCurrentDialog();
            }
            else
            {
                storyText.text = DialogManager.GetDogErrorCurrentDialog();
            }
            StartCoroutine(Delay(() => { storyText.text = ""; }));
        }
    }

    private void OnDestroy()
    {
        UniEvent.RemoveListener<EventDefine.EventBloodUpdate>(OnEventBloodUpdate);
    }

    private IEnumerator Delay(Action callBack)
    {
        yield return new WaitForSeconds(2);
        callBack?.Invoke();
    }

}
