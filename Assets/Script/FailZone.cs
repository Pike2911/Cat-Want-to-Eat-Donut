using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailZone : MonoBehaviour
{
    public Transform Restart;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Score")
        {
            Destroy(collision.gameObject);
            PauseGame();
            Restart.gameObject.SetActive(true);
        }

    }
    private void PauseGame()
    {
        Time.timeScale = 0;
    }
}
