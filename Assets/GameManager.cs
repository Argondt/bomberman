using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour

{
	public GameOverMenu GameOverMenu;
	public void GameOver()
    {
		if (GameObject.FindWithTag("Player") == null && GameObject.FindWithTag("Player2") == null)
		{
			string remis = "remis";
			GameOverMenu.Setup(remis);
			
		}
		else if (GameObject.FindWithTag("Player") == null)
		{
			string p1Win = "Win p1";
			GameOverMenu.Setup(p1Win);
			
		}
		else if (GameObject.FindWithTag("Player2") == null)
		{
			string p2Win = "Win p1";
			GameOverMenu.Setup(p2Win);
			
		}
	}
	

   
}

