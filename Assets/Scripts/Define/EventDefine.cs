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

    public class EventMonsterCry : IEventMessage
    {
        public static void SendMessage()
        {
            UniEvent.SendMessage(new EventMonsterCry());
        }
    }

    public class EventFlyFly:IEventMessage
    {
        public static void SendMessage()
        {
            UniEvent.SendMessage(new EventFlyFly());
        }
    }

    public class EventPlateMove : IEventMessage
    {
        public static void SendMessage()
        {
            UniEvent.SendMessage(new EventPlateMove());
        }
    }
}
