using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class roomSelectionController : MonoBehaviour
{
    private GameObject cursor;
    [SerializeField] private string cursorName;
    [SerializeField] private GridManager gridManager;
    private void Start()
    {
        cursor = GameObject.Find(cursorName);
        this.gameObject.SetActive(false);
    }

    public void dismiss() 
    {
        cursor.GetComponent<MouseController>().menu = false;
        this.gameObject.SetActive(false);
    }

    public void changeRoom(GameObject newRoom) 
    {
        for(int i=0;i<gridManager.grid.getHeight();i++) 
        {
            for (int j = 0;j < gridManager.grid.getLenght();j++)
            {
                if(cursor.GetComponent<MouseController>().getOulined().Equals(gridManager.grid.getTileAt(i,j).getGO()))
                { 
                    Destroy(cursor.GetComponent<MouseController>().getOulined());
                    cursor.GetComponent<MouseController>().resetSelection();

                    newRoom = Instantiate(newRoom);
                    gridManager.grid.setTileAt(new Tile(gridManager.grid, i,j,newRoom),i,j);
                    gridManager.grid.getTileAt(i, j).getGO().transform.position = new Vector3(2 * j-0.05739141f, 2 * i-0.1604499f, 0);
                    newRoom.transform.SetParent(gridManager.transform,true);
                    
                    dismiss();
                    return;
                }
            }
        }
        
    }

}
