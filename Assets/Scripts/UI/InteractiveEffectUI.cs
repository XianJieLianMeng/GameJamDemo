using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UniFramework.Event;
using UnityEngine;
using UnityEngine.UI;

public class InteractiveEffectUI : MonoBehaviour
{
    public List<Transform> fly1Path;
    public List<Transform> fly2Path;
    public List<Transform> fly3Path;
    public Transform point;
    
    private GameObject _fly1;
    private GameObject _fly2;
    private GameObject _fly3;
    private Vector3 _pointPosition;
    private bool _flag;

    private void Awake()
    {
        _fly1 = Resources.Load<GameObject>("Prefabs/Fly1");
        _fly2 = Resources.Load<GameObject>("Prefabs/Fly2");
        _fly3 = Resources.Load<GameObject>("Prefabs/Fly3");
    }

    private void OnEnable()
    {
        UniEvent.AddListener<EventDefine.EventFlyFly>(FlyFlyBtnClick);
    }

    private void OnDisable()
    {
        UniEvent.RemoveListener<EventDefine.EventFlyFly>(FlyFlyBtnClick);
    }

    void Start()
    {
        _flag = false;
        _pointPosition = point.position;
    }

    private void FlyFlyBtnClick(IEventMessage message)
    {
        if (message is EventDefine.EventFlyFly msg)
        {
            if (_flag)
            {
                return;
            }

            _flag = true;
            var fly1 = Instantiate(_fly1,transform);
            var fly2 = Instantiate(_fly2,transform);
            var fly3 = Instantiate(_fly3,transform);
            fly1.transform.position = _pointPosition;
            fly2.transform.position = _pointPosition;
            fly3.transform.position = _pointPosition;
            var path1 = BezierPathUtility.CalculateBezierPath(10, fly1Path[0].position, fly1Path[1].position, fly1Path[2].position);
            var path2 = BezierPathUtility.CalculateBezierPath(10, fly2Path[0].position, fly2Path[1].position, fly2Path[2].position);
            var path3 = BezierPathUtility.CalculateBezierPath(10, fly3Path[0].position, fly3Path[1].position, fly3Path[2].position);
            fly1.transform.DOPath(path1, 2).SetEase(Ease.Linear).SetLookAt(0.01f).OnComplete(() => { Destroy(fly1,3f);});
            fly2.transform.DOPath(path2, 3).SetEase(Ease.Linear).SetLookAt(0.01f).OnComplete(() => { Destroy(fly2,2f);});
            fly3.transform.DOPath(path3, 4).SetEase(Ease.Linear).SetLookAt(0.01f).OnComplete(() => { Destroy(fly3,1f);
                _flag = false;
            }); 
        }
    }
}
