using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float rLimit;//right limit
    public float lLimit;//left limit
    public float tLimit;//top limit
    public float bLimit;//bottom limit
    public float speed=1;//movement speed multiplier

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.x < lLimit)
        {
            gameObject.transform.position = new Vector3(lLimit, gameObject.transform.position.y, gameObject.transform.position.z);
        }

        if (gameObject.transform.position.x > rLimit)
        {
            gameObject.transform.position = new Vector3(rLimit, gameObject.transform.position.y, gameObject.transform.position.z);
        }

        if (gameObject.transform.position.y <bLimit)
        {
            gameObject.transform.position=new Vector3 (gameObject.transform.position.x,bLimit, gameObject.transform.position.z);
        }

        if (gameObject.transform.position.y > tLimit)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, tLimit, gameObject.transform.position.z);
        }
        gameObject.transform.Translate(Vector3.right * speed * Input.GetAxis("Horizontal")*Time.deltaTime);
        gameObject.transform.Translate(Vector3.up * speed * Input.GetAxis("Vertical")*Time.deltaTime);
    }
}
