using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
   public void Exit()
    {
        Application.Quit();
        Debug.Log("Game closed");
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }
}
