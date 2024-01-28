using Define;
using UnityEngine;

namespace Game
{
    public class DialogManager
    {
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
                SnakeDialogIndex++;
            }
            return s;
        }
        public static string GetDuYanCorrectCurrentDialog()
        {
            var s = GlobalConfig.DuYanCorrectDialog[DuYanCorrectDialogIndex];
            DuYanCorrectDialogIndex++;
            return s;
        }
        public static string GetDuYanErrorCurrentDialog()
        {
            var s = GlobalConfig.DuYanErrorDialog[DuYanErrorDialogIndex];
            DuYanErrorDialogIndex++;
            return s;
        }
        public static string GetDogCorrectCurrentDialog()
        {
            var s = GlobalConfig.DogCorrectDialog[DogCorrectDialogIndex];
            DogCorrectDialogIndex++;
            return s;
        }
        public static string GetDogErrorCurrentDialog()
        {
            var s = GlobalConfig.DogErrorDialog[DogErrorDialogIndex];
            DogErrorDialogIndex++;
            return s;
        }
        public static string GetSaDanCorrectCurrentDialog()
        {
            var s = GlobalConfig.SaDanCorrectDialog[SaDanCorrectDialogIndex];
            SaDanCorrectDialogIndex++;
            return s;
        }
        public static string GetSaDanErrorCurrentDialog()
        {
            var s = GlobalConfig.SaDanErrorDialog[SaDanErrorDialogIndex];
            SaDanErrorDialogIndex++;
            return s;
        }
    }
}