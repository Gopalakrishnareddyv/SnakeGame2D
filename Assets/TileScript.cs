using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TileScript : MonoBehaviour
{
    protected Vector2Int gridpos;
    public Vector2Int GridPosition
    {
        get { return gridpos; }
    }
    public void MoveToGrid(int x,int y)
    {
        float xf = x;
        float yf = y;
        //transform.position=new Vector3(GridManager.Instance.StartPoint.x+(xf/GridManager.Instance)
    }
}
