using UnityEngine;
public class CameraMovement : MonoBehaviour
{
    public GameObject playerBody;
    public float MaxX;
    public float MinX;
    public float MaxY;
    public float MinY;
    
    void FixedUpdate()
    {
        if (playerBody.transform.position.x >= MaxX || playerBody.transform.position.x <= MinX)
        {
            if (playerBody.transform.position.y >= MaxY || playerBody.transform.position.y <= MinY) transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            else                                                                               transform.position = new Vector3(transform.position.x, playerBody.transform.position.y, transform.position.z);
        }
        else if (playerBody.transform.position.y >= MaxY || playerBody.transform.position.y <= MinY)
        {
            if (playerBody.transform.position.x >= MaxX || playerBody.transform.position.x <= MinX) transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            else                                                                               transform.position = new Vector3(playerBody.transform.position.x, transform.position.y, transform.position.z);
        }
        else transform.position = playerBody.transform.position + new Vector3(0,0,transform.position.z);
    }
}