using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPause;
    public GameObject pauseMenuUi;
    public GameObject GameOverMenu;
    public Text message;

    void Start() {
        Resume();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        pauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;
    }
    public void Pause()
    {
        pauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
    }
    public void Restart()
    {
        Debug.Log("dupa");
        Time.timeScale = 1f;
        GameOverMenu.SetActive(false);
        // Application.LoadLevel(Application.loadedLevel);
        SceneManager.LoadScene("Game");
        Debug.Log("Restart");
    }
    public void LoadMenu() 
    {
        SceneManager.LoadScene("Menyu");
    }
    public void WlaczanieGameOverPanel()
    {
        GameOverMenu.SetActive(true);
        Time.timeScale = 1f;
        
    }
    public void WyaczanieGameOverPanel()
    {
        GameOverMenu.SetActive(false);
        Time.timeScale = 0f;
        
    }
  
}
