using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailZone : MonoBehaviour
{
    [SerializeField] private Transform Restart;
    [SerializeField] private Transform PlayAgain;
    [SerializeField] private GameController gameCon;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Score")
        {
            Destroy(collision.gameObject);
            gameCon.PauseGame();
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
}
