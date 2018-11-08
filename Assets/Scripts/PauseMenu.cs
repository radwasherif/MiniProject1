using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PauseMenu : MonoBehaviour {
	public SoundManagerPlay soundManager; 
	// Use this for initialization
	void Start () {
		gameObject.SetActive(false); 
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Restart() {
		SceneManager.LoadScene("Scene1"); 
	}

	public void Resume() {
		PlayerMove.SetStop(false); 
		TogglePause(); 
	}

	public void Quit() {
		Application.Quit(); 
	}

	public void TogglePause() {
		if(!gameObject.active) {
			soundManager.MenuSound(); 
		} else {
			soundManager.GameSound(); 
		}
		gameObject.SetActive(!gameObject.active); 
		
	}
}
