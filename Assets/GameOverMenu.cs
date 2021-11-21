using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    

    public void Restart()
    {
        // Application.LoadLevel(Application.loadedLevel);
        SceneManager.LoadScene("Game");
       
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menyu");
    }
    public Text message;
    public void Setup(string Mesage)
    {
        gameObject.SetActive(true);
        message.text = Mesage.ToString();
    }
}
