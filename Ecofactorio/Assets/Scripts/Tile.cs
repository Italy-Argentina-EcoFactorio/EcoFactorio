using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile
{
    public enum TileType {empty,room}
    protected TileType type;
    protected GameObject go;
    protected Grid grid;

    protected int x, y;

    public Tile(Grid grid,int x,int y)
    {
        this.grid = grid;
        this.x = x;
        this.y = y;
    }
}
