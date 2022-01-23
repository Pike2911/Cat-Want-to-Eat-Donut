using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ScoreCounter : MonoBehaviour
{
    public static int ScoreValue = 0;
    Text score;

    private void Start()
    {
        score = GetComponent<Text>();
    }
    private void Update()
    {
        score.text = "Score : " + ScoreValue; 
    }
}
