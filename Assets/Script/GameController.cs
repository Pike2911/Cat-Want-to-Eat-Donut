using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField]private AudioSource Audio;

    public Transform StartButton;
    public Transform PlayButton;


    private void Start()
    {
        PauseGame();
    }
    public void ResetGame()
    {
        SceneManager.LoadScene("SampleScene");
        ResumeGame();

        PlayerController.PlayerLife -= 1;
        Debug.Log(PlayerController.PlayerLife);
    }
    public void StartGame()
    {
        StartButton.gameObject.SetActive(false);
        ResumeGame();
        Audio.Play();
    }
    public void PlayAgain()
    {
            ScoreCounter.ScoreValue = 0;
        PlayerController.PlayerLife = 2;
            SceneManager.LoadScene("SampleScene"); 
    }
    private void ResumeGame()
    {
        Time.timeScale = 1;
    }
    private void PauseGame()
    {
        Time.timeScale = 0;
    }
}
