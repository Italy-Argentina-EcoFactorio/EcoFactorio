using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid
{
    protected int width, height;
    protected Tile[,] tiles;


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
        };
        return tiles[x,y];
    }

}
