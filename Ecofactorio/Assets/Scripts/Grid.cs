using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid
{
    int width, height;
    public Tile[,] tiles;
    

    public Grid(int width, int height) 
    {
        this.width = width;
        this.height = height;
        tiles = new Tile[width, height];

        //instantiates the matrix
        for (int i = 0; i < width; i++) 
        {
            for (int j = 0; j < height; j++)
            {
                tiles[i, j] = new Tile(this, i, j);
            }    
        }
    }

    public Tile getTileAt(int x, int y) 
    {
        if(x>width||y>height||y<0||x<0)
        {
            Debug.LogError("Tile [" + x + ", " + y + "] is out of range");
        }
        return tiles[x,y];
    }

    public void setTileAt(Tile tile, int x, int y)
    {
        if (tile == null) Debug.LogError("cannot set null tile");
        if (x > width || y > height || y < 0 || x < 0)
        {
            Debug.LogError("Tile [" + x + ", " + y + "] is out of range");
        }
        tiles[x,y] = tile;
    }

    public int getWidth() { return width; }
    public int getHeight() { return height; }

    

}
