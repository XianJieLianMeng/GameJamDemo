using System;
using System.Collections;
using System.Collections.Generic;
using UniFramework.Event;
using UnityEngine;
using UnityTimer;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Chessboard chessboard;
    private Timer timer;

    private void Awake()
    {
        UniEvent.Initalize();
    }

    private void Start()
    {
        UniEvent.AddListener<EventDefine.EventGameStart>(OnEventGameStart);
    }

    private void OnEventGameStart(IEventMessage message)
    {
        if(message is EventDefine.EventGameStart)
        {
            GameStart();
        }
    }

    private void GameStart()
    {
        var level = PlayerPrefs.GetInt("Level", 0);

        if (level >= 0 && level < GameDefine.MaxLevel)
        {
            int[,] initMapData = GameData.GetInitMapData(level);
            int[,] endMapData = GameData.GetEndMapData(level);
            int[,] modData = GameData.GetModData(level);

            LevelManager.Instance.InitLevel(initMapData, endMapData, modData, level);
        }
        else
        {
            // 处理无效的关卡索引
            Debug.LogError("Invalid level index: " + level);
        }
        chessboard.Init();
        timer = Timer.Register(20f, () => { EventDefine.EventMonsterCry.SendMessage(); }, null, true);
    }

    private void OnDestroy()
    {
        if(timer != null)
        {
            Timer.Cancel(timer);
        }
        UniEvent.RemoveListener<EventDefine.EventGameStart>(OnEventGameStart);
    }
}
