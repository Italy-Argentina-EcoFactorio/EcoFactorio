using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public Grid grid;
    // Start is called before the first frame update
    void Start()
    {
        grid = new Grid(30, 30);
        for (int i = 0; i<grid.getWidth();i++)
            for(int j = 0; j < grid.getHeight();j++)
                Debug.Log(grid.getTileAt(i,j));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
