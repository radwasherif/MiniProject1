using UnityEngine;
using System.Collections;

public class SoundManagerPlay : MonoBehaviour {
	AudioSource game, menu; 
	// Use this for initialization
	void Start () {
		AudioSource [] audios = GetComponents<AudioSource>(); 
		game = audios[0]; 
		menu = audios[1]; 
		if(SoundManager.mute) {
			game.mute = true; 
			menu.mute = true;
			print("MUTE BOTH");  
		} else {
			game.mute = false; 
			menu.mute = true; 
			print("PLAY GAME SOUND");
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
		print("Game Sound"); 
	}
	public void MenuSound() {
		if(SoundManager.mute)
			return; 

		game.mute = true; 
		menu.mute = false; 
		print("Menu Sound"); 
	}
}
