using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 groundPos = this.gameObject.transform.position; 
		Vector3 playerPos = GameObject.Find("Player").transform.position; 

		if(groundPos.z < playerPos.z - 50) {
		 	GameObject.Destroy(this.gameObject);

		}
	}
}
