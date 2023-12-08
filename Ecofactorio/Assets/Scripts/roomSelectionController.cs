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
        //selected GO
        GameObject outlined = cursor.GetComponent<MouseController>().getOulined();
        //Tile of the grid to modify
        Tile old = gridManager.findTileByGO(outlined);
        if( old != null )
        {
            Destroy(outlined);
            cursor.GetComponent<MouseController>().resetSelection();
            newRoom = Instantiate(newRoom);

            //this if positions the tile correctly
            if (newRoom.CompareTag("Background"))
            {
                newRoom.transform.position = new Vector3(2 * old.getJ(), 2 * old.getI(), 0);
            }
            else
            {
                newRoom.transform.position = new Vector3(2 * old.getJ() - 0.05739141f, 2 * old.getI() - 0.1604499f, 0);
            }
            //set the GO of the tile to the new room
            old.setGO(newRoom);
            //close the menù
            dismiss();
        }   
    }

}
