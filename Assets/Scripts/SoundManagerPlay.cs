using UnityEngine;
using System.Collections;

public class SoundManagerPlay : MonoBehaviour {
	AudioSource game, menu; 
	// Use this for initialization
	void Start () {
		AudioSource [] audios = GetComponents<AudioSource>(); 
		game = audios[0]; 
		menu = audios[0]; 
		if(SoundManager.mute) {
			game.mute = true; 
			menu.mute = true; 
		} else {
			game.mute = false; 
			menu.mute = true; 
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void GameSound() {
		if(SoundManager.mute)
			return; 
		game.mute = false; 
		menu.mute = true; 
	}
	public void MenuSound() {
		if(SoundManager.mute)
			return; 

		game.mute = true; 
		menu.mute = false; 
	}
}
