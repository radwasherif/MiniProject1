using UnityEngine;
using System.Collections;
using UnityEngine.UI; 
public class PlayerCollisions : MonoBehaviour {
	public Text scoreText;
	public static int score = 0; 
	public DeathMenu deathMenu; 

	public Material red, green, blue; 
	// Use this for initialization
	void Start () {
		scoreText.text = "Score: " + score; 
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "Score: " + score; 
	}

	void OnCollisionEnter(Collision c) {
		if(c.gameObject.tag == "Obstacle") {
			// print("COLLISION"); 
			print(this.gameObject.name); 
			Color hisColor = c.gameObject.GetComponent<Renderer>().material.color; 
			Color myColor = this.gameObject.GetComponent<Renderer>().material.color; 
			if( hisColor == myColor ){
				// print("SAME MATERIAL");
				score += 10; 
				// print("Score " + score); 
			} else {
				score /=2;
				// print("Score " + score); 
				if (score == 0) {
					GetComponent<PlayerMove>().SetDead(true);
					deathMenu.Dead(); 
				}

			}
			GameObject.Destroy(c.gameObject); 
		}
	}

	void OnTriggerEnter(Collider c) {
		if(c.gameObject.name == "RedLight") {
			print("COLLISION RED LIGHT"); 
			GetComponent<Renderer>().material = red; 
		} else if(c.gameObject.name == "BlueLight") {
			print("COLLISION BLUE LIGHT"); 
			GetComponent<Renderer>().material = blue; 
		} else if(c.gameObject.name == "GreenLight") {
			print("COLLISION GREEN LIGHT"); 
			GetComponent<Renderer>().material = green; 
		}
	}
}
