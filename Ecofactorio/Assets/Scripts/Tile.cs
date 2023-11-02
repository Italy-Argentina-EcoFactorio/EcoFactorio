using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile
{
    public enum TileType {empty,room}
    TileType type;
    GameObject go;
    Grid grid;

    protected int x, y;

    public Tile(Grid grid,int x,int y, GameObject go)
    {
        this.grid = grid;
        this.x = x;
        this.y = y;
        type = TileType.empty;
        this.go = go;
    }
    
    
}
