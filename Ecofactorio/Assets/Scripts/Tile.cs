using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile
{
    enum TileType {empty,emptyRoom,room}
    TileType type;
    GameObject go;
    Grid grid;

    protected int x, y;

    public Tile(Grid grid,int x,int y)
    {
        this.grid = grid;
        this.x = x;
        this.y = y;
        type= TileType.empty;
    }

    public void setGO(GameObject go) 
    {
        this.go = go;
    }

    public GameObject getGO()
    {
        return this.go; 
    }
    
}
