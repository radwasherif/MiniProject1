using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour {
	public Transform Ground;
	public Transform[] obstacles; 
	bool firstTime = true;
	bool generated = false;  
	Vector3 groundPos = new Vector3(0, 0, 12); 
	Vector3 playerPos;
	// Use this for initialization
	void Start () {
		Ground = (Transform) Instantiate(Ground, new Vector3(0, 0, 0), Quaternion.identity);

	}
	
	// Update is called once per frame
	void Update () {
		groundPos = Ground.transform.position; 
		playerPos = GameObject.Find("Player").transform.position; 
		print("GROUND " + groundPos);
		print("PLAYER " + playerPos);		
		if (groundPos.z - playerPos.z > 10 && !generated) {
			Ground = (Transform) Instantiate(Ground, new Vector3(groundPos.x, groundPos.y, groundPos.z + 50), Quaternion.identity);
		generated = true;
		print("NEW GROUND!");			
		}
		if (generated && playerPos.z >= groundPos.z - 20.0) {
			generated = false; 
			print("GENERATED FALSE"); 
		}
	}
}
