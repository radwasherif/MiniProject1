using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SoundManager : MonoBehaviour {
	public static bool mute = false; 
	public Button muteButton;	
	// Use this for initialization
	public AudioSource currentSoundtrack; 

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Mute() {
		AudioSource sound = GetComponent<AudioSource>(); 
		sound.mute = !sound.mute; 
		mute = !mute;
		print(muteButton.GetComponentInChildren<Text>()); 
		if(sound.mute) {
			muteButton.GetComponentInChildren<Text>().text = "Unmute"; 
			 
		} else {
			muteButton.GetComponentInChildren<Text>().text = "Mute"; 
		}
	}
}
