using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class DialogUI : MonoBehaviour
{
    public Transform right;
    public GameObject monster;
    public Button overBtn;
    void Start()
    {
        overBtn.onClick.AddListener(OverBtnClick);
    }

    // Update is called once per frame
    private void OverBtnClick()
    {
        var first = new Vector3(-54f,0,0);
        right.DOLocalMove(first, 2.5f).SetEase(Ease.InCubic).OnComplete(() =>
        {
            right.DOLocalMove(Vector3.zero, 0.1f).SetEase(Ease.InCirc).OnComplete(() =>
            {
                monster.SetActive(true);
            });
        });
    }
}
