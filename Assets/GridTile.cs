using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridTile : TileScript
{
    [SerializeField] GameObject applePrefab;
    GameObject apple;
    bool hasapple = false;

    public bool HasApple()
    {
        return hasapple;
    }
    public bool SetApple()
    {
        if (hasapple)
        {
            return false;
        }
        else
        {
            apple = Instantiate(applePrefab,transform.position, Quaternion.identity);
            apple.transform.parent = transform;
            apple = null; ;
            return true;
        }
    }
    public bool TakeApple()
    {
        if (!hasapple)
        {
            return false;
        }
        else
        {
            hasapple = false;
            Destroy(apple.gameObject);
            applePrefab = null;
            return false;
        }
    }
}
