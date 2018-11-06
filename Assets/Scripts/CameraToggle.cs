using UnityEngine;
using System.Collections;

public class CameraToggle : MonoBehaviour {
	public Camera top, thirdPerson; 
	// Use this for initialization
	void Start () {
		top.enabled = false; 
		thirdPerson.enabled = true; 
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.C)) {
			top.enabled = !top.enabled; 
			thirdPerson.enabled = !thirdPerson.enabled; 
		}
	}
}
