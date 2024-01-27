using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractiveEffectUI : MonoBehaviour
{
    public Button flyFlyBtn;

    private GameObject _fly1;
    private GameObject _fly2;
    private GameObject _fly3;

    private void Awake()
    {
        _fly1 = Resources.Load<GameObject>("Prefabs/Fly1");
        _fly2 = Resources.Load<GameObject>("Prefabs/Fly2");
        _fly3 = Resources.Load<GameObject>("Prefabs/Fly3");
    }

    void Start()
    {
        flyFlyBtn.onClick.AddListener(FlyFlyBtnClick);
    }

    private void FlyFlyBtnClick()
    {
        
    }
}
