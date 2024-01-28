using System;
using System.Collections;
using System.Collections.Generic;
using UniFramework.Event;
using UnityEngine;
using UnityEngine.EventSystems;

public class MonsterAnimationController :MonoBehaviour, IPointerClickHandler
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        UniEvent.AddListener<EventDefine.EventMonsterLaugh>(OnEventHandler);
        UniEvent.AddListener<EventDefine.EventMonsterCry>(OnEventHandler);
    }

    private void OnDestroy()
    {
        UniEvent.RemoveListener<EventDefine.EventMonsterLaugh>(OnEventHandler);
        UniEvent.RemoveListener<EventDefine.EventMonsterCry>(OnEventHandler);
    }

    private void OnEventHandler(IEventMessage message)
    {
        if(message is EventDefine.EventMonsterLaugh)
        {
            animator.SetTrigger("laugh");
        }
        else if(message is EventDefine.EventMonsterCry)
        {
            animator.SetTrigger("cry");
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        animator.SetTrigger("laugh");
        AudioManager.Instance.PlaySoundEffect(0);
    }
}
