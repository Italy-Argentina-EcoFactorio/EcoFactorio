using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public Grid grid;
    public GameObject backgroundTile;
    public int gridHeight,gridLenght;
    // Start is called before the first frame update
    void Start()
    {
        grid = new Grid(gridHeight,gridLenght);
        instantiateGrid();
    }

    void instantiateGrid()
    {
        //these 2 for loops will instantiate the background tiles and give them the right placement
        for (int i = 0; i < grid.getHeight(); i++)
        {
            for (int j = 0; j < grid.getLenght(); j++)
            {
                //instantiate the tile
                grid.getTileAt(i, j).setGO(Instantiate(backgroundTile));
                //make the tile GO a parent of the grid manager and keeps it's attributes invarieted
                grid.getTileAt(i, j).getGO().transform.SetParent(this.transform,true);
                //position the tile using absolute coordinates
                grid.getTileAt(i, j).getGO().transform.Translate(2 * j, 2 * i, 0, Space.World);
            }
        }
    }

    public Tile findTileByGO(GameObject key)
    {
        for (int i = 0; i < grid.getHeight(); i++)
        {
            for (int j = 0; j < grid.getLenght(); j++)
            {
                if(grid.getTileAt(i, j).getGO()==key) return grid.getTileAt(i, j);
            }
        }
        return null;
    }

}
