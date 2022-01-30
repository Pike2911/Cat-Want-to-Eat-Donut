using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Transform StartButton;
    private void Start()
    {
        PauseGame();
    }
    public void ResetGame()
    {
        SceneManager.LoadScene("SampleScene");
        ResumeGame();
    }
    public void StartGame()
    {
        StartButton.gameObject.SetActive(false);
        ResumeGame();
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
