using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoleController : MonoBehaviour,IPointerClickHandler
{
    [SerializeField]
    private GameObject hole;

    private void Start()
    {
        hole.SetActive(false);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!hole.activeSelf)
        {
            hole.SetActive(true);
        }
        EventDefine.EventFlyFly.SendMessage();
    }
}
