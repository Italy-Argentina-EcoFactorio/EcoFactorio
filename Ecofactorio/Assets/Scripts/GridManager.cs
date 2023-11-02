using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    Grid grid;
    // Start is called before the first frame update
    void Start()
    {
        grid = new Grid(30, 30);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
