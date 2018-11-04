using UnityEngine;
using System.Collections;

public class AddObstacles : MonoBehaviour {
	public Transform[] obstacles; 

	// Use this for initialization
	void Start () {
			int numObctacles = Random.Range(1, 5);
			for(int i = 0; i < numObctacles; i++) {
				int idx = Random.Range(0, obstacles.Length);
				Vector3 gPos = this.gameObject.transform.position;
				float zOffset = Random.Range(-20.0f, 20.0f); 
				float xOffset = Random.Range(-7.0f, 7.0f); 
				Vector3 oPos = new Vector3(gPos.x + xOffset, 0.6f, gPos.z + zOffset); 
				GameObject obs = Instantiate(obstacles[idx], oPos, Quaternion.identity) as GameObject; 
				obs.transform.SetParent(this.gameObject.transform); 
			}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
