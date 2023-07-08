using UnityEngine;

public class Formula : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Part")
        {
	        if(collision.gameObject.GetComponent<Part>().isCorrect)
			{
				Debug.Log("Ya");	
			}
            else
            {
	            Debug.Log("Nein");
            }
	        Destroy(collision.gameObject);
        }
    }   
}