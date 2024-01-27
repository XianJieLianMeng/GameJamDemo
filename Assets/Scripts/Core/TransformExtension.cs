using System.Linq;
using UnityEngine;

public static class TransformExtensions
{
    public static void ClearChildren(this Transform parentTransform)
    {
        // 销毁所有子节点的 GameObject
        foreach (Transform child in parentTransform.Cast<Transform>().ToList())
        {
            GameObject.Destroy(child.gameObject);
        }
    }
}
