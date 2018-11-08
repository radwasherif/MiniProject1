using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PauseMenu : MonoBehaviour {
	
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
		gameObject.SetActive(!gameObject.active); 
	}
}
