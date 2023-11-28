using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Tile
{
    GameObject go;
    Grid grid;

    protected int i, j;

    public Tile(Grid grid,int i,int j)
    {
        this.grid = grid;
        this.i = i;
        this.j = j;
    }

    public Tile(Grid grid, int i, int j, GameObject go)
    {
        this.grid = grid;
        this.i = i;
        this.j = j;
        this.go = go;
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
