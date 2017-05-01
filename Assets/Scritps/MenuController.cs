using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

	void OnGUI () 
	{
		if(GUI.Button(new Rect(Screen.width / 2 -75, Screen.height / 2, 150, 35), "Play")){
			SceneManager.LoadScene("scene");
		}
		if(GUI.Button(new Rect(Screen.width / 2 -75, Screen.height / 2 + 75, 150, 35), "Exit")){
			Application.Quit();
		}	
	}
}
