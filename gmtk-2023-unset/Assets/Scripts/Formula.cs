using UnityEngine;
using UnityEngine.SceneManagement;

public class Formula : MonoBehaviour
{
	public float formulaSpeed;
	public float startX;
	private float stopX;
	public float partsNeaded;
	private float partsRecived;
	public float endX;
	public string nextScene;

	void Awake()
	{
		stopX = transform.position.x;
		transform.position = new Vector3(startX, transform.position.y, transform.position.z);
	}
	void FixedUpdate()
	{
		if ((partsRecived < partsNeaded && transform.position.x > stopX) || partsRecived >= partsNeaded)
		{
			transform.position -= new Vector3(formulaSpeed * Time.deltaTime, 0f, 0f);
			if (transform.position.x < endX) SceneManager.LoadScene(nextScene);
		}
	}
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Part")
        {
	        partsRecived++;
	        Destroy(collision.gameObject);
        }
    }   
}