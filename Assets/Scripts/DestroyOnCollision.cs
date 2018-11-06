using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class DestroyOnCollision : MonoBehaviour {
	public Text scoreText;
	private int score = 0; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision c) {
		if(c.gameObject.name == "Player") {
			print("COLLISION"); 
			print(this.gameObject.name); 
			Color hisColor = c.gameObject.GetComponent<Renderer>().material.color; 
			Color myColor = this.gameObject.GetComponent<Renderer>().material.color; 
			if( hisColor == myColor ){
				print("SAME MATERIAL");
			}
			GameObject.Destroy(this.gameObject); 
		}
	}
}
