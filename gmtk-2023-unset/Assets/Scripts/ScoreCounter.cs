using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] 
    private TMP_Text _title;

    public float score = 0;
    
    // Update is called once per frame
    void FixedUpdate()
    {
        score = score + Time.deltaTime;
        _title.text = ""+Math.Floor(score);
    }
}
