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
                tiles[i, j] = new Tile(this, i, j,GameObject.Find("empty_room_x1"));
            }    
        }
        Debug.Log("grid created x=" + width + ", y=" + width);
    }

    public Tile[,] getTiles()
    {
        return tiles;
    }


    public Tile getTileAt(int x, int y) 
    {
        if(x>width||y>height||y<0||x<0)
        {
            Debug.LogError("Tile [" + x + ", " + y + "] is out of range");
        }
        return tiles[x,y];
    }
    
    public int getWidth() { return width; }
    public int getHeight() { return height; }
    //public void setWidth(int width) {  this.width = width; }
    //public void setHeight(int height) {  this.height = height; }

    public void setTileAt(Tile tile,int x, int y) 
    {
        if (x > width || y > height || y < 0 || x < 0)
        {
            Debug.LogError("Tile [" + x + ", " + y + "] is out of range");
        }
        if(tile==null) Debug.LogError("cannot set null tile");
        tiles[x,y] = tile;
    }

}
