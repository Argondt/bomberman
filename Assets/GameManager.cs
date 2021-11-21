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
			FindObjectOfType<PauseMenu>().WlaczanieGameOverPanel();
			string remis = "remis";
			text.text = remis;
			
		}
		else if (GameObject.FindWithTag("Player") == null)
		{
			FindObjectOfType<PauseMenu>().WlaczanieGameOverPanel();
			string p1Win = "Win p1";
			
			text.text = p1Win;

		}
		else if (GameObject.FindWithTag("Player2") == null)
		{
			FindObjectOfType<PauseMenu>().WlaczanieGameOverPanel();
			string p2Win = "Win p2";
			text.text = p2Win;

		}
	}
	

   
}

