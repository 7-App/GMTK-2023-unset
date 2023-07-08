using System.Xml.Schema;
using UnityEngine;

public class PlayerBobing : MonoBehaviour
{
    #region Setuping variables
    public float animationSpeed;
    public float maxAngle;
    private float rotateDirection = 1f;
    #endregion

    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") != 0f || Input.GetAxisRaw("Vertical") != 0f)
        {
            if (transform.rotation.z * 180 > maxAngle) rotateDirection = -1f; //Checks if rotation limit is crossed
            else if (transform.rotation.z * 180 < -maxAngle) rotateDirection = 1f; //

            transform.Rotate(0, 0, animationSpeed * rotateDirection * Time.deltaTime); //Shakes the player sprite while moving
        }
        else transform.rotation = new Quaternion(0f, 0f, 0f, 0f); //Returns sprite to defaul position after movemin
    }
}