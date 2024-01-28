using System;
using System.Collections;
using System.Collections.Generic;
using Define;
using DG.Tweening;
using Game;
using UnityEngine;
using UnityEngine.UI;

public class DialogUI : MonoBehaviour
{
    public Transform right;
    public GameObject left;
    public Button continueBtn;
    public GameObject chessboard;
    public Text content;
    public Image headSculpture;
    void Start()
    {
        content.text = DialogManager.GetSnakeCurrentDialog();
        continueBtn.onClick.AddListener(OnContinueBtnClick);
    }

    private void OnContinueBtnClick()
    {
        if (DialogManager.SnakeDialogIndex == 6)
        {
            //todo 大眼怪走来
        }
        switch (DialogManager.CurrentActor)
        {
            case Actor.Snake:
                content.text = DialogManager.GetSnakeCurrentDialog();
                break;
            case Actor.DuYan:
                
                break;
            case Actor.Dog:
                break;
            case Actor.SaDan:
                break;
            case Actor.Self:
                break;
        }
    }
    
    private void OverStartDialog()
    {
        var first = new Vector3(-54f,0,0);
        right.DOLocalMove(first, 2.5f).SetEase(Ease.InCubic).OnComplete(() =>
        {
            right.DOLocalMove(Vector3.zero, 0.1f).SetEase(Ease.InCirc).OnComplete(() =>
            {
                left.SetActive(true);
                EventDefine.EventPlateMove.SendMessage();
                chessboard.SetActive(true);
            });
        });
    }
}
