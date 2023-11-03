using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePosition : MonoBehaviour
{
    //[SerializeField] means that i can drag and drop a camera from the unity interface
    //main camera is just the camera use to view the game
    [SerializeField] private Camera mainCamera;
    // Update is called once per frame
    void Update()
    {
        //ray it a ray that goes from the main camera position to the cursor position on the screen
        Ray ray= mainCamera.ScreenPointToRay(Input.mousePosition);
        
        //if the ray hits something
        if(Physics.Raycast(ray, out RaycastHit raycastHit))
        {   
            //!!!note the raycast will only hit colliders so if an object!!! 
            //!!!does not have any the ray wont hit                      !!!
            //move to the position where it hit
            transform.position = raycastHit.point;
        }
    }
}
