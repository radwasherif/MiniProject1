using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 
using System.Collections;

public class PauseMenu : MonoBehaviour {
	public AndroidButtons androidButtons; 
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
			androidButtons.Hide();  
		} else {
			soundManager.GameSound();
			androidButtons.Show();  
		}
		gameObject.SetActive(!gameObject.active); 
		
	}
}
