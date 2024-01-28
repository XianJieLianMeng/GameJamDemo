using System.Collections;
using System.Collections.Generic;
using UniFramework.Event;
using UnityEngine;
using static EventDefine;

public class NPCUI : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> npcList = new List<GameObject>();

    void Start()
    {
        UniEvent.AddListener<EventDefine.EventGameStartLevel>(OnEventGameStartLevel);
    }

    private void OnDestroy()
    {
        UniEvent.RemoveListener<EventDefine.EventGameStartLevel>(OnEventGameStartLevel);
    }

    private void OnEventGameStartLevel(IEventMessage message)
    {
        if (message is EventGameStartLevel startLevelMsg)
        {
            ChangeBg(startLevelMsg.Level);
        }
    }

    private void ChangeBg(int level)
    {
        for (int i = 0; i < npcList.Count; i++)
        {
            if (level == i)
            {
                npcList[level].SetActive(true);
            }
            else
            {
                npcList[level].SetActive(false);
            }
        }

    }
}
