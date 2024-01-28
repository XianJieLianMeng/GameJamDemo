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

    public class EventGameStart : IEventMessage
    {
        public static void SendMessage()
        {
            UniEvent.SendMessage(new EventGameStart());
        }
    }
    
    public class EventStartDialogOver : IEventMessage
    {
        public static void SendMessage()
        {
            UniEvent.SendMessage(new EventStartDialogOver());
        }
    }
    
    public class EventDuYanCome : IEventMessage
    {
        public static void SendMessage()
        {
            UniEvent.SendMessage(new EventDuYanCome());
        }
    }
    
    public class EventActorBack : IEventMessage
    {
        public static void SendMessage()
        {
            UniEvent.SendMessage(new EventActorBack());
        }
    }

    public class EventGameStartLevel : IEventMessage
    {
        public int Level;
        public static void SendMessage(int level)
        {
            UniEvent.SendMessage(new EventGameStartLevel() { Level = level});
        }
    }

    public class EventBloodUpdate : IEventMessage
    {
        public int Count;

        public static void SendMessage(int count)
        {
            UniEvent.SendMessage(new EventBloodUpdate() { Count = count});
        }
    }
}
