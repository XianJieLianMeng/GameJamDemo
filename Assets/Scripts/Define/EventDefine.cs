using System.Collections;
using System.Collections.Generic;
using UniFramework.Event;
using UnityEngine;

public class EventDefine 
{
    public class EventMonsterLaugh:IEventMessage
    {
        public static void SendMessage()
        {
            UniEvent.SendMessage(new EventMonsterLaugh());
        }
    }
}
