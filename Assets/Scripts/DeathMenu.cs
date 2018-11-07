using UnityEngine;
using System.Collections;
using UnityEngine.UI; 
// using UnityEngine.SceneManagement; 

public class DeathMenu : MonoBehaviour {
	public Text finalScoreText;
	// Use this for initialization
	void Start () {
		gameObject.SetActive(false); 
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Restart() {
		// UnityEngine.SceneManagement.SceneManager.LoadScene("Scene1"); 	
	}
}
