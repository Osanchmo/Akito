using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OnPlayerDestroy : MonoBehaviour {
	public Text text;
	int count;
	Vector2 playerPos;
	AudioSource audio;
	void Start()
	{
		audio = GetComponent<AudioSource>();
		//variable persistente
		count = PlayerPrefs.GetInt("attempts");
		PlayerPrefs.SetInt("attempts", 0);
		text.text = "Attempt: " + count;
		audio.Play();

	}
	//RELOAD SCENE WHEN DIES
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.transform.tag == "killer"){
			loadSceneAndStartMusic();
		}
	}

	void loadSceneAndStartMusic(){
		SceneManager.LoadScene("scene");
		count++;
		PlayerPrefs.SetInt("attempts", count);
	}
}
