﻿using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
	// int lane = 0; 
	// bool clicked = false; 
	private CharacterController controller; 
	private Vector3 moveVector; 
	public bool dead = false; 
	private int speed = 1;
	// private bool levelUp = false; 
	// Use this for initialization
	void Start () {
		// speed = 1; 
		// dead = false; 
		controller = GetComponent<CharacterController>();
		// print(GameObject.Find("Directional Light").gameObject.ToString()); 	
	}
	
	// Update is called once per frame
	void Update () {
		if(dead)
			return; 
		moveVector = Vector3.zero; 

		moveVector.x = Input.GetAxisRaw("Horizontal") * 3; 

		moveVector.y = 0; 

		moveVector.z = 7.0f * speed; 
		
		controller.Move(moveVector * Time.deltaTime); 

		if(this.gameObject.transform.position.y > 0.6f) {
			this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, 0.6f, this.gameObject.transform.position.z);  
		}

		if(PlayerCollisions.score % 50 == 0) {
			speed = (PlayerCollisions.score / 50 + 1); 
		}

		// print("PLAYER: " + gameObject.transform.position); 

		// transform.Translate(0, 0, Time.deltaTime*3);
		
		

		// if(Input.GetAxis("Horizontal") > 0 && !clicked) {
		// 	if(lane < 1) {lane++; transform.Translate(7, 0, 0); 					Debug.Log("right"); Debug.Log(lane); clicked = true; }		
		// }
		// if(Input.GetAxis("Horizontal") < 0 && !clicked) {
		// 	if(lane > -1) {lane--; transform.Translate(-7, 0, 0); 					Debug.Log("left"); Debug.Log(lane); clicked = true;}		
		// } 
		
		// if(Input.GetAxis("Horizontal") == 0) {
		// 	clicked = false; 
		// }
	}

	public void SetDead(bool dead) {
		this.dead = dead; 
	}

}
