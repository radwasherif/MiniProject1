﻿using UnityEngine;
using UnityEngine.SceneManagement; 
using System.Collections;
public class StartGame : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void PlayGame() {
		SceneManager.LoadScene("Scene1");
	}

	
}
