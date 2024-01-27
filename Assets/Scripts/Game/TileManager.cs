using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class TileManager : SingletonMonoBehaviour<TileManager>
{
    [SerializeField]
    private List<GameObject> tiles;

    public GameObject InstiateTile(int type,Vector3 position,Quaternion rotation)
    {
        return GameObject.Instantiate(tiles[type],position,rotation);
    }
}
