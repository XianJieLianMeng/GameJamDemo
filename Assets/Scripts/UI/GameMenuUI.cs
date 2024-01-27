using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMenuUI : MonoBehaviour
{
    public Button startGameBtn;
    public Button goOnGameBtn;
    public Button operationBtn;
    public Button exitBtn;

    private void Start()
    {
        startGameBtn.onClick.AddListener(StartGameBtnClick);
    }

    private void StartGameBtnClick()
    {
        Debug.Log("开始游戏");
    }
    
}
