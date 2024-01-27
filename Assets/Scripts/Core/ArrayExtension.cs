using System.Collections.Generic;
using System.Linq;

public static class ArrayExtension 
{
    public static bool AreArraysEqual<T>(this T[,] array1, T[,] array2)
    {
        // 判断数组维度是否相同
        if (array1.GetLength(0) != array2.GetLength(0) || array1.GetLength(1) != array2.GetLength(1))
        {
            return false;
        }

        // 比较数组元素
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                if (!EqualityComparer<T>.Default.Equals(array1[i, j], array2[i, j]))
                {
                    return false;
                }
            }
        }

        return true;
    }
}
