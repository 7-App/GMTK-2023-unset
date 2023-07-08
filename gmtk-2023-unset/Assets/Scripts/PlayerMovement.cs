using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed; //Units per second
    public Rigidbody2D rb;
    private Vector2 movement;
    void FixedUpdate()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
        
        rb.MovePosition(rb.position + movement * movementSpeed * Time.fixedDeltaTime);
    }
}