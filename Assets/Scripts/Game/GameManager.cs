using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Chessboard chessboard;
    // Start is called before the first frame update
    void Start()
    {
        LevelManager.Instance.InitLevel( GameData.level1InitMapData, GameData.level1EndMapData,1);
        chessboard.Init();
    }
}
