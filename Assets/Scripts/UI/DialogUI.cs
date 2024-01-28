using System;
using System.Collections;
using System.Collections.Generic;
using Define;
using DG.Tweening;
using Game;
using UniFramework.Event;
using UnityEngine;
using UnityEngine.UI;

public class DialogUI : MonoBehaviour
{
    public Transform right;
    public GameObject left;
    public Button continueBtn;
    public GameObject chessboard;
    public GameObject dialogBox;
    public Text content;
    public Text errorContent;
    public Image headSculpture;

    private Sprite dog;
    private Sprite duyan;
    private Sprite sadan;
    private Sprite self;
    void Start()
    {
        content.text = DialogManager.GetSnakeCurrentDialog();
        continueBtn.onClick.AddListener(OnContinueBtnClick);
        dog = Resources.Load<Sprite>("Sprites/三头犬");
        duyan = Resources.Load<Sprite>("Sprites/大眼");
        sadan = Resources.Load<Sprite>("Sprites/撒旦");
        self = Resources.Load<Sprite>("Sprites/玩家");
    }

    private void OnContinueBtnClick()
    {
        switch (DialogManager.CurrentActor)
        {
            case Actor.Snake:
                headSculpture.sprite = self;
                content.text = DialogManager.GetSnakeCurrentDialog();
                break;
            case Actor.DuYan:
                headSculpture.sprite = duyan;
                if (DialogManager.DuYanIsSuccess)
                {
                    content.text = DialogManager.GetDuYanCorrectCurrentDialog();
                }
                else
                {
                    errorContent.text = DialogManager.GetDuYanErrorCurrentDialog();
                }
                break;
            case Actor.Dog:
                headSculpture.sprite = dog;
                if (DialogManager.DuYanIsSuccess)
                {
                    content.text = DialogManager.GetDogCorrectCurrentDialog();
                }
                else
                {
                    errorContent.text = DialogManager.GetDogErrorCurrentDialog();
                }
                break;
            case Actor.SaDan:
                headSculpture.sprite = sadan;
                if (DialogManager.DuYanIsSuccess)
                {
                    content.text = DialogManager.GetSaDanCorrectCurrentDialog();
                }
                else
                {
                    errorContent.text = DialogManager.GetSaDanErrorCurrentDialog();
                }
                break;
            case Actor.Self:
                headSculpture.sprite = self;
                break;
        }
    }
    
    private void OverStartDialog(IEventMessage message)
    {
        dialogBox.SetActive(false);
        continueBtn.gameObject.SetActive(false);
        EventDefine.EventGameStart.SendMessage();
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

    private void OnEnable()
    {
        UniEvent.AddListener<EventDefine.EventStartDialogOver>(OverStartDialog);
    }

    private void OnDisable()
    {
        UniEvent.RemoveListener<EventDefine.EventStartDialogOver>(OverStartDialog);
    }
}
