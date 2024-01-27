using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
        goOnGameBtn.onClick.AddListener(GoOnGameBtnClick);
        operationBtn.onClick.AddListener(OperationBtnClick);
        exitBtn.onClick.AddListener(ExitBtnClick);
    }

    private void StartGameBtnClick()
    {
        Debug.Log("开始游戏");
        SceneManager.LoadScene("Game");
    }

    private void GoOnGameBtnClick()
    {
        var level = PlayerPrefs.GetInt("Level",0);
        if (level == 0)
        {
            Debug.Log("游戏无存档，是否开启新游戏~");
        }
        SceneManager.LoadScene("Game");
    }
    
    private void OperationBtnClick()
    {
        Debug.Log("设置");
    }
    
    private void ExitBtnClick()
    {
        Debug.Log("退出");
    }
}
