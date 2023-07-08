using UnityEngine;
public class movement : MonoBehaviour
{
    public GameObject playerBody;
    void FixedUpdate()
    {
        if (playerBody.transform.position.x > 10 || playerBody.transform.position.x < -10)
        {
            if (playerBody.transform.position.y > 10 || playerBody.transform.position.y < -10) transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            else                                                                               transform.position = new Vector3(transform.position.x, playerBody.transform.position.y, transform.position.z);
        }
        else if (playerBody.transform.position.y > 10 || playerBody.transform.position.y < -10)
        {
            if (playerBody.transform.position.z > 10 || playerBody.transform.position.z < -10) transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            else                                                                               transform.position = new Vector3(playerBody.transform.position.x, transform.position.y, transform.position.z);
        }
        else transform.position = playerBody.transform.position + new Vector3(0,0,transform.position.z);
    }
}