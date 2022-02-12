using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailZone : MonoBehaviour
{
    public Transform Restart;
    public Transform PlayAgain;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Score")
        {
            Destroy(collision.gameObject);
            PauseGame();
            Debug.Log(PlayerController.PlayerLife);
            if (PlayerController.PlayerLife > 0)
            {
                Restart.gameObject.SetActive(true);
            }
            else if(PlayerController.PlayerLife == 0)
            {
                PlayAgain.gameObject.SetActive(true);
            }
        }

    }
    private void PauseGame()
    {
        Time.timeScale = 0;
    }
}
