using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class movement : MonoBehaviour
{
    void FixedUpdate()
    {
        if (GameObject.Find("Square").transform.position.x > 10 || GameObject.Find("Square").transform.position.x < -10)
        {
            if (GameObject.Find("Square").transform.position.y > 10 || GameObject.Find("Square").transform.position.y < -10)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            }
            else
            {
                transform.position = new Vector3(transform.position.x, GameObject.Find("Square").transform.position.y, transform.position.z);
            }
        }
        else if (GameObject.Find("Square").transform.position.y > 10 || GameObject.Find("Square").transform.position.y < -10)
        {
            if (GameObject.Find("Square").transform.position.z > 10 || GameObject.Find("Square").transform.position.z < -10)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            }
            else
            {
                transform.position = new Vector3(GameObject.Find("Square").transform.position.x, transform.position.y, transform.position.z);
            }
        }
        else
        {
            transform.position = GameObject.Find("Square").transform.position + new Vector3(0,0,transform.position.z);
        }
    }
}
