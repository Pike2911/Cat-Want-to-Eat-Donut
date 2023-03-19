using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] private AudioSource Audio;
    [SerializeField] private Transform StartButton;
    [SerializeField] private Transform SettingMenu;
    [SerializeField] private BannerAds bannerAds;

    private void Start()
    {
        bannerAds.LoadBanner();
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
    public void ResumeGame()
    {
        Time.timeScale = 1;
        Audio.Play();
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
        Audio.Stop();
    }
}
