using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
	int lane = 0; 
	bool clicked = false; 
	private CharacterController controller; 
	private Vector3 moveVector; 
	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();	
	}
	
	// Update is called once per frame
	void Update () {
		moveVector = Vector3.zero; 

		moveVector.x = Input.GetAxisRaw("Horizontal") * 3; 

		moveVector.y = 0; 

		moveVector.z = 5.0f; 
		
		controller.Move(moveVector * Time.deltaTime); 
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
}
