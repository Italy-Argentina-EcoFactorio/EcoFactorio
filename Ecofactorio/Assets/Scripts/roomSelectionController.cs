using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomSelectionController : MonoBehaviour
{
    public GameObject cursor;

    private void Start()
    {
        cursor = GameObject.Find("Cursor");
    }

    public void dismiss() 
    {
        cursor.GetComponent<MouseController>().menu = false;
        this.gameObject.SetActive(false);
    }

}
