using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormulaMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public float formulaSpeed;
    
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -50)
        {
            transform.position = transform.position + new Vector3(100, 0, 0);
        }
        transform.position -= new Vector3(formulaSpeed * Time.deltaTime, 0f, 0f);
    }
}
