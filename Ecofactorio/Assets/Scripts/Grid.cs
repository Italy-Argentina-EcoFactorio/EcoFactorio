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

    public Tile getTileAt(int i, int j) 
    {
        if(i>height||j>lenght||j<0||i<0)
        {
            Debug.LogError("Tile [" + i + ", " + j + "] is out of range");
        }
        return tiles[i,j];
    }

    public void setTileAt(Tile tile, int i, int j)
    {
        if (tile == null) Debug.LogError("cannot set null tile");
        if (i > height || j > lenght || j < 0 || i < 0)
        {
            Debug.LogError("Tile [" + i + ", " + j + "] is out of range");
            return;
        }
        tiles[i,j] = tile;
    }

    public int getHeight() { return height; }
    public int getLenght() { return lenght; }

    

}
