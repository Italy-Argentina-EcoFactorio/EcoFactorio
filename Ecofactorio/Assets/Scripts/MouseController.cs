using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    //[SerializeField] means that i can drag and drop a camera from the unity interface
    //main camera is just the camera use to view the game
    [SerializeField] private Camera mainCamera;
    private static GameObject RCHit;//gameobject hitted by the raycast

    public bool menu = false;
    [SerializeField] private String menuName;
    private GameObject roomSelection;
    private void Start()
    {
        roomSelection = GameObject.Find(menuName);
        // roomManagementUI = GameObject.Find()
    }

    // Update is called once per frame
    void Update()
    {
        moveMouse();
        if (Input.GetMouseButtonDown(0) && !menu)
        {
            applyOutline(RCHit);
        }
        if (detectDoubleClick())
        {
            callRoomSelectionMenu();
            //callRoomManagement();
        }
    }

    //manages mouse position
    private void moveMouse()
    {
        //ray it a ray that goes from the main camera position to the cursor position on the screen
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        //if the ray hits something
        if (Physics.Raycast(ray, out RaycastHit raycastHit))
        {
            //!!!note the raycast will only hit colliders so if an object!!! 
            //!!!does not have any the ray wont hit                      !!!
            //move to the position where it hit
            transform.position = raycastHit.point;
            RCHit=raycastHit.collider.gameObject;
        }
    }

    [SerializeField] private float timeBetweenClicks = 0.2f;
    private float lastClickTime=0,thisClickTime=0;
    private int clickSum=0;
    private bool detectDoubleClick()
    {
        if(clickSum==2&&thisClickTime-lastClickTime<=timeBetweenClicks)
        {
            clickSum = 0;
            Debug.Log("double click detected");
            return true;
        }
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("clickSum increased");
            clickSum++;
            lastClickTime = thisClickTime;
            thisClickTime = Time.time;
        } 
        return false;
    }


    [SerializeField] private Material outline;
    private Material originalMaterial;
    private GameObject lastCollision;
    private bool pressed = false; //it's made to understand if the first object has been clicked
    private void applyOutline(GameObject GO)
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (pressed&&lastCollision!=GO)
            {
                //give the last object it's original color
                lastCollision.GetComponent<MeshRenderer>().material = originalMaterial;

                //memorize the last object that the cursor collided with and it's color
                lastCollision = GO;
                originalMaterial = lastCollision.GetComponent<MeshRenderer>().material;

                //apply the outline 
                lastCollision.GetComponent<MeshRenderer>().material = outline;

                clickSum = 0;
            }else if(!pressed)
            {
                //memorize the last object that the cursor collided with and it's color
                lastCollision = GO;
                originalMaterial = lastCollision.GetComponent<MeshRenderer>().material;
                //apply the outline 
                lastCollision.GetComponent<MeshRenderer>().material = outline;
                pressed = true;
            }
        }
    }

    public GameObject getOulined() { return lastCollision; }

    public void resetSelection() 
    {
        clickSum = 0;
        pressed = false;
    }

    private void callRoomSelectionMenu()
    {
        menu = true;
        roomSelection.SetActive(true);
    }

    private GameObject roomManagementUI;
    private void callRoomManagement()
    {
        menu = true;
        roomManagementUI.SetActive(true);
    }
}
