using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField]private AudioSource Audio;

    public Transform StartButton;
    public Transform SettingMenu;

    private void Start()
    {
        PauseGame();
    }
    public void ResetGame()
    {
        SceneManager.LoadScene("SampleScene");
        ResumeGame();
        PlayerController.PlayerLife -= 1;

    }
    public void StartGame()
    {
        StartButton.gameObject.SetActive(false);
        ResumeGame();
    }
    public void PlayAgain()
    {
            ScoreCounter.ScoreValue = 0;
            PlayerController.PlayerLife = 2;
            SceneManager.LoadScene("SampleScene"); 
    }
    public void ResumeGameMenu()
    {
        ResumeGame();
        SettingMenu.gameObject.SetActive(false);
    }
    public void SettingButton()
    {
        PauseGame();
        SettingMenu.gameObject.SetActive(true);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    private void ResumeGame()
    {
        Time.timeScale = 1;
        Audio.Play();
    }
    private void PauseGame()
    {
        Time.timeScale = 0;
        Audio.Stop();
    }
}
