using UnityEngine;
using System.Collections;
using UnityEngine.UI; 
public class PlayerCollisions : MonoBehaviour {
	public Text scoreText;
	public static int score = 0; 
	public DeathMenu deathMenu; 
	private AudioSource colorChangeAudio, scoreGainAudio, scoreLossAudio; 
	public Material red, green, blue; 
	// Use this for initialization
	void Start () {
		score = 0; 
		scoreText.text = "Score: " + score;
		AudioSource [] audios = GetComponents<AudioSource>(); 
		colorChangeAudio = audios[0]; 
		scoreGainAudio = audios[1]; 
		scoreLossAudio = audios[2]; 
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
				scoreGainAudio.Play(); 
				StartCoroutine(wait(scoreGainAudio.clip.length));  
			} else {
				score /=2;
				scoreLossAudio.Play();
				StartCoroutine(wait(scoreLossAudio.clip.length));  
				// print("Score " + score); 
				if (score == 0) {
					PlayerMove.SetStop(true);
					deathMenu.Dead(); 
				}
			}
			GameObject.Destroy(c.gameObject); 
		}
	}

	void OnTriggerEnter(Collider c) {
		if(c.gameObject.name == "RedLight") {
			print("COLLISION RED LIGHT"); 
			if(GetComponent<Renderer>().material != red) {
				GetComponent<Renderer>().material = red;
				colorChangeAudio.Play(); 
				StartCoroutine(wait(colorChangeAudio.clip.length));  
			}
		} else if(c.gameObject.name == "BlueLight") {
			print("COLLISION BLUE LIGHT"); 
			if(GetComponent<Renderer>().material != blue) {
				GetComponent<Renderer>().material = blue;
				colorChangeAudio.Play(); 
				StartCoroutine(wait(colorChangeAudio.clip.length));  
			} 
		} else if(c.gameObject.name == "GreenLight") {
			print("COLLISION GREEN LIGHT"); 
			if(GetComponent<Renderer>().material != green) {
				GetComponent<Renderer>().material = green;
				colorChangeAudio.Play(); 
				StartCoroutine(wait(colorChangeAudio.clip.length));  
			}
			
		}
	}

	private IEnumerator wait(float seconds) {
		yield return new WaitForSeconds(seconds); 
	}
}
