using Define;
using UnityEngine;

namespace Game
{
    public enum Actor
    {
        Snake,  //蛇
        DuYan,  //独眼
        Dog,    //狗
        SaDan,  //撒旦
        Self,   //玩家
    }
    
    public class DialogManager
    {
        public static bool DuYanIsSuccess = true;
        public static bool DogIsSuccess = true;
        public static bool SaDanIsSuccess = true;
        
        public static Actor CurrentActor = Actor.Snake;
        
        public static int SnakeDialogIndex = 0;
        public static int DuYanCorrectDialogIndex = 0;
        public static int DuYanErrorDialogIndex = 0;
        public static int DogCorrectDialogIndex = 0;
        public static int DogErrorDialogIndex = 0;
        public static int SaDanCorrectDialogIndex = 0;
        public static int SaDanErrorDialogIndex = 0;

        public static string GetSnakeCurrentDialog()
        {
            var s = GlobalConfig.SnakeDialog[SnakeDialogIndex];
            if (SnakeDialogIndex < GlobalConfig.SnakeDialog.Length -1)
            {
                if (SnakeDialogIndex == 6)
                {
                    CurrentActor = Actor.DuYan;
                    EventDefine.EventDuYanCome.SendMessage();
                }
                SnakeDialogIndex++;
            }
            return s;
        }
        public static string GetDuYanCorrectCurrentDialog()
        {
            var s = GlobalConfig.DuYanCorrectDialog[DuYanCorrectDialogIndex];
            if (DuYanCorrectDialogIndex < GlobalConfig.DuYanCorrectDialog.Length -1)
            {
                if (DuYanCorrectDialogIndex == 2)
                {
                    //开始游戏
                    EventDefine.EventStartDialogOver.SendMessage();
                    EventDefine.EventActorBack.SendMessage();
                }
                DuYanCorrectDialogIndex++;
            }
            return s;
        }
        public static string GetDuYanErrorCurrentDialog()
        {
            var s = GlobalConfig.DuYanErrorDialog[DuYanErrorDialogIndex];
            if (DuYanErrorDialogIndex < GlobalConfig.DuYanErrorDialog.Length -1)
            {
                DuYanErrorDialogIndex++;
            }
            return s;
        }
        public static string GetDogCorrectCurrentDialog()
        {
            var s = GlobalConfig.DogCorrectDialog[DogCorrectDialogIndex];
            if (DogCorrectDialogIndex < GlobalConfig.DogCorrectDialog.Length -1)
            {
                DogCorrectDialogIndex++;
            }
            return s;
        }
        public static string GetDogErrorCurrentDialog()
        {
            var s = GlobalConfig.DogErrorDialog[DogErrorDialogIndex];
            if (DogErrorDialogIndex < GlobalConfig.DogErrorDialog.Length -1)
            {
                DogErrorDialogIndex++;
            }
            return s;
        }
        public static string GetSaDanCorrectCurrentDialog()
        {
            var s = GlobalConfig.SaDanCorrectDialog[SaDanCorrectDialogIndex];
            if (SaDanCorrectDialogIndex < GlobalConfig.SaDanCorrectDialog.Length -1)
            {
                SaDanCorrectDialogIndex++;
            }
            return s;
        }
        public static string GetSaDanErrorCurrentDialog()
        {
            var s = GlobalConfig.SaDanErrorDialog[SaDanErrorDialogIndex];
            if (SaDanErrorDialogIndex < GlobalConfig.SaDanErrorDialog.Length -1)
            {
                SaDanErrorDialogIndex++;
            }
            return s;
        }
    }
}