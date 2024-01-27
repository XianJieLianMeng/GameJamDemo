using System.Collections;
using System.Collections.Generic;
using UniFramework.Event;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlateController : MonoBehaviour,IPointerClickHandler
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        UniEvent.AddListener<EventDefine.EventMonsterLaugh>(OnEventHandler);
    }

    private void OnDestroy()
    {
        UniEvent.RemoveListener<EventDefine.EventMonsterLaugh>(OnEventHandler);
    }

    private void OnEventHandler(IEventMessage message)
    {
        if (message is EventDefine.EventMonsterLaugh)
        {
            animator.SetTrigger("laugh");
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        animator.SetTrigger("laugh");
    }
}
