using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile
{
    GameObject go;
    Grid grid;

    protected int x, y;

    public Tile(Grid grid,int x,int y)
    {
        this.grid = grid;
        this.x = x;
        this.y = y;
    }

    public GameObject getGO()
    {
        //Debug.Log("Tile returned");
        return go; 
    }
    public void setGO(GameObject go) 
    {
        //Debug.Log("Tile setted");
        this.go = go;
    }
}
