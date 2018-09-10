using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
	public float speedGo = 4f;
	private CharacterController control;
	public float gravity = -9.8f;
	// Use this for initialization
	void Start () {
		control = GetComponent <CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		float deltaX = Input.GetAxis ("Horizontal") * speedGo;
		float deltaZ = Input.GetAxis ("Vertical") * speedGo;
		Vector3 move = new Vector3 (deltaX, 0, deltaZ);
		move = Vector3.ClampMagnitude (move, speedGo);
		move.y = gravity;
		move *= Time.deltaTime;
		move = transform.TransformDirection (move);
		control.Move (move);
	}
}
