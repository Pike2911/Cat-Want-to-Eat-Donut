using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeCounter : MonoBehaviour
{
    Text Life;

    private void Start()
    {
        Life = GetComponent<Text>();
    }
    private void Update()
    {
        Life.text = "Life : " + PlayerController.PlayerLife;
    }
}
