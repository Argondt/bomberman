using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour

{
	
	public Text text;

	void Update()
    {
		if (GameObject.FindWithTag("Player") == null && GameObject.FindWithTag("Player2") == null)
		{
			foundWinner("There is no winner!");
		}
		else if (GameObject.FindWithTag("Player") == null)
		{
			foundWinner("Player 2 is a winner!");
		}
		else if (GameObject.FindWithTag("Player2") == null)
		{
			foundWinner("Player 1 is a winner!");
		}
	}

	void foundWinner(string winner) {
		FindObjectOfType<PauseMenu>().WlaczanieGameOverPanel();
		text.text = winner;
	}
	

   
}

