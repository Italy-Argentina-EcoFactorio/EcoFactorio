using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    [SerializeField] private String menuName;
    private void Start()
    {
        doorSelection = GameObject.Find(menuName);
    }
    // Update is called once per frame
    void Update()
    {
        moveMouse();
        if(Input.GetMouseButtonDown(0))
        {
            clickSum++;
            if(clickSum>2 ) clickSum = 1;
            if(clickSum==1 ) firstClickTime = Time.time;
        }
    }


    //[SerializeField] means that i can drag and drop a camera from the unity interface
    //main camera is just the camera use to view the game
    [SerializeField] private Camera mainCamera;
    

    //manages inputs and mouse position
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


            if (Input.GetMouseButtonDown(0)&&!menu)
            {
                applyOutline(raycastHit.collider);
            }
            if (detectDoubleClick()) 
            {
                callRoomSelectionMenu();
            }
               
             
            
        

        }
    }

    private int clickSum = 0;
    private float firstClickTime, timeBetweenClicks = 0.5f;
    private bool detectDoubleClick()
    {
        if(Time.time < firstClickTime+timeBetweenClicks)
        {
            if(clickSum>=2)
            {
                clickSum = 0;
                Debug.Log("double click detected");
                return true; 
            }
        }
        return false;
    }


    [SerializeField] private Material outline;
    private Material originalMaterial;
    private GameObject lastCollision;
    private bool pressed = false; //it's made to understand if the first object has been clicked
    
    private void applyOutline(Collider collision) 
    {
        if (!pressed)
        {
            if (Input.GetMouseButtonDown(0))
            {
                //memorize the last object that the cursor collided with and it's color
                lastCollision = collision.gameObject;
                originalMaterial = lastCollision.GetComponent<MeshRenderer>().material;

                //apply the outline 
                lastCollision.GetComponent<MeshRenderer>().material = outline;
            }
            pressed = true;
        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                //give the last object it's original color
                lastCollision.GetComponent<MeshRenderer>().material = originalMaterial;

                //memorize the last object that the cursor collided with and it's color
                lastCollision = collision.gameObject;
                originalMaterial = lastCollision.GetComponent<MeshRenderer>().material;

                //apply the outline 
                lastCollision.GetComponent<MeshRenderer>().material = outline;
            }
        }
    }


    public bool menu = false;
    private GameObject doorSelection;
    private void callRoomSelectionMenu()
    {
        menu = true;
        doorSelection.SetActive(true);
    }
}
