using UnityEngine;
using System.Collections;

public class GenerateGround : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 groundPos = GameObject.Find("Ground").transform.position; 
		Vector3 playerPos = GameObject.Find("Player").transform.position; 
		
		if (groundPos.z == playerPos.z) {
					
		}
	}	
}
