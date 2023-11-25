using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid
{
    int height, lenght;
    public Tile[,] tiles;
    

    public Grid(int height, int lenght) 
    {
        this.height = height;
        this.lenght = lenght;
        tiles = new Tile[height, lenght];

        //instantiates the matrix
        for (int i = 0; i < height; i++) 
        {
            for (int j = 0; j < lenght; j++)
            {
                tiles[i, j] = new Tile(this, i, j);
            }    
        }
    }

    public Tile getTileAt(int x, int y) 
    {
        if(x>height||y>lenght||y<0||x<0)
        {
            Debug.LogError("Tile [" + x + ", " + y + "] is out of range");
        }
        return tiles[x,y];
    }

    public void setTileAt(Tile tile, int x, int y)
    {
        if (tile == null) Debug.LogError("cannot set null tile");
        if (x > height || y > lenght || y < 0 || x < 0)
        {
            Debug.LogError("Tile [" + x + ", " + y + "] is out of range");
        }
        tiles[x,y] = tile;
    }

    public int getHeight() { return height; }
    public int getLenght() { return lenght; }

    

}
