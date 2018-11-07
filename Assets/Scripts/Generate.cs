using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour {
	private Transform Ground;
	public Transform[] grounds; 
	bool firstTime = true;
	bool generated = false;  
	Vector3 groundPos = new Vector3(0, 0, 12); 
	Vector3 playerPos;
	// Use this for initialization
	void Start () {
		int r = Random.Range(0, grounds.Length); 
		Ground = (Transform) Instantiate(grounds[r], new Vector3(0, 0, 0), Quaternion.identity);

	}
	
	// Update is called once per frame
	void Update () {
		groundPos = Ground.transform.position; 
		playerPos = GameObject.Find("Player").transform.position; 
		// print("GROUND " + groundPos);
		// print("PLAYER " + playerPos);		
		if (groundPos.z - playerPos.z > 10 && !generated) {
			int r = Random.Range(0, grounds.Length);
			print("RANDOM " + r);  
			Ground = (Transform) Instantiate(grounds[r], new Vector3(groundPos.x, groundPos.y, groundPos.z + 50), Quaternion.identity);
			generated = true;
		// print("NEW GROUND!");			
		}
		if (generated && playerPos.z >= groundPos.z - 20.0) {
			generated = false; 
			// print("GENERATED FALSE"); 
		}
	}


}
