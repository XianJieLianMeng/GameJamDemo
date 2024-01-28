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
        Debug.Log("1");
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
            Debug.Log($"ChangeNpc level = {startLevelMsg.Level}");
            ChangeNpc(startLevelMsg.Level);
        }
    }

    private void ChangeNpc(int level)
    {
        Debug.Log($"level = {level}");
        for (int i = 0; i < npcList.Count; i++)
        {
            if (i == level)
            {
                npcList[i].SetActive(true);
                Debug.Log($"ChangeNPC {npcList[level].gameObject.name}");
            }
            else
            {
                npcList[i].SetActive(false);
            }
        }

    }
}
