using System.Collections;
using System.Collections.Generic;
using UniFramework.Event;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlateController : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        UniEvent.AddListener<EventDefine.EventPlateMove>(OnEventHandler);
    }

    private void OnDestroy()
    {
        UniEvent.RemoveListener<EventDefine.EventPlateMove>(OnEventHandler);
    }

    private void OnEventHandler(IEventMessage message)
    {
        if (message is EventDefine.EventPlateMove)
        {
            Debug.Log("plateMove");
            animator.SetTrigger("plateMove");
        }
    }
}
