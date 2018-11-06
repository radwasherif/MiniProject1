using UnityEngine;
using System.Collections;

public class AddObstacles : MonoBehaviour {
	public GameObject[] obstacles;  
	// Use this for initialization
	void Start () {
			int numObctacles = Random.Range(1, 5);
			for(int i = 0; i < numObctacles; i++) {
				int idx = Random.Range(0, obstacles.Length);
				Vector3 gPos = this.gameObject.transform.position;
				float zOffset = Random.Range(-20.0f, 20.0f); 
				float xOffset = Random.Range(-7.0f, 7.0f); 
				Vector3 oPos = new Vector3(gPos.x + xOffset, 0.6f, gPos.z + zOffset); 
				Instantiate(obstacles[idx], oPos, Quaternion.identity); 
				// print("CREATE OBS:" + idx + "at  " + oPos); 
			}
			// Light lt = this.gameObject.AddComponent<Light>();
			// lt.type = LightType.Spot; 
			// int color = Random.Range(0, 3);
			// if(color == 0) {
			// 	lt.color = Color.red; 
			// } else if (color == 1) {
			// 	lt.color = Color.blue;
			// } else {
			// 	lt.color = Color.green;
			// }
			// lt.gameObject.transform.Translate(0, 7, 0); 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
