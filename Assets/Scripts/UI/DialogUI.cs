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
    public GameObject actor;
    public GameObject dogActor;
    public GameObject duyanActor;
    public GameObject sadanActor;

    private Sprite dog;
    private Sprite duyan;
    private Sprite sadan;
    private Sprite self;
    void Start()
    {
        duyanActor.SetActive(true);
        content.text = DialogManager.GetSnakeCurrentDialog();
        continueBtn.onClick.AddListener(OnContinueBtnClick);
        dog = Resources.Load<Sprite>("Sprites/三头犬");
        duyan = Resources.Load<Sprite>("Sprites/大眼");
        sadan = Resources.Load<Sprite>("Sprites/撒旦");
        self = Resources.Load<Sprite>("Sprites/玩家");
        left.SetActive(false);
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

    private void ActorCome(IEventMessage message)
    {
        if (message is EventDefine.EventActorCome msg)
        {
            var vector3 = new Vector3(336f,37,0);
            var level = PlayerPrefs.GetInt("Level");
            duyanActor.SetActive(level == 0);
            dogActor.SetActive(level == 1);
            sadanActor.SetActive(level == 2);
            actor.transform.DOLocalMove(vector3, 1f);
        }
    }
    
    private void ActorBack(IEventMessage message)
    {
        if (message is EventDefine.EventActorBack msg)
        {
            actor.SetActive(true);
            var vector3 = new Vector3(2269f,164,0);
            actor.transform.DOLocalMove(vector3, 1f);
        }
    }
    
    private void OverStartDialog(IEventMessage message)
    {
        if (message is EventDefine.EventStartDialogOver msg)
        {
            gameObject.SetActive(false);
            EventDefine.EventGameStart.SendMessage();
            var first = new Vector3(-54f,0,0);
            right.DOLocalMove(first, 2.5f).SetEase(Ease.InCubic).OnComplete(() =>
            {
                right.DOLocalMove(Vector3.zero, 0.1f).SetEase(Ease.InCirc).OnComplete(() =>
                {
                    //todo 派发左侧显示事件
                    left.SetActive(true);
                    EventDefine.EventPlateMove.SendMessage();
                    chessboard.SetActive(true);
                });
            });
        }
    }

    private void StartLevel2(IEventMessage message)
    {
        if (message is EventDefine.EventStartLevel2 msg)
        {
            OnContinueBtnClick();
            chessboard.SetActive(false);
            right.DOLocalMove(new Vector3(3882,0,0),2.5f).OnComplete((() =>
            {
                left.SetActive(false);
                gameObject.SetActive(true);
            }));
        }
    }

    private void OnEnable()
    {
        UniEvent.AddListener<EventDefine.EventStartDialogOver>(OverStartDialog);
        UniEvent.AddListener<EventDefine.EventActorCome>(ActorCome);
        UniEvent.AddListener<EventDefine.EventActorBack>(ActorBack);
        UniEvent.AddListener<EventDefine.EventStartLevel2>(StartLevel2);
    }

    private void OnDestroy()
    {
        UniEvent.RemoveListener<EventDefine.EventStartDialogOver>(OverStartDialog);
        UniEvent.RemoveListener<EventDefine.EventActorCome>(ActorCome);
        UniEvent.RemoveListener<EventDefine.EventActorBack>(ActorBack);
        UniEvent.RemoveListener<EventDefine.EventStartLevel2>(StartLevel2);
    }
}
