using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour {
	public enum RotationAccess{
		MouseXY = 0,
		MouseX = 1,
		MouseY = 2
	}
	public RotationAccess axes = RotationAccess.MouseXY;
	public float speedHor = 9f;

	public float maxVert = 45f;
	public float minVert = -45f;
	private float rotationX = 0;



	void Start(){
		
		Rigidbody body = GetComponent<Rigidbody> ();
		if (body != null)
			body.freezeRotation = true;
	}

	void Update () {
		if (axes == RotationAccess.MouseX) {
			transform.Rotate (0, Input.GetAxis("Mouse X")*speedHor, 0);
		}
		 else if (axes == RotationAccess.MouseY) {
			rotationX -= Input.GetAxis ("Mouse Y") * speedHor;
			rotationX = Mathf.Clamp (rotationX, minVert, maxVert);
			float rotationY = transform.localEulerAngles.y;
			transform.localEulerAngles = new Vector3 (rotationX, rotationY, 0);
		}
		else {
			rotationX -= Input.GetAxis ("Mouse Y") * speedHor;
			rotationX = Mathf.Clamp (rotationX, minVert, maxVert);
			float delta = Input.GetAxis ("Mouse X") * speedHor;
			float rotationY = transform.localEulerAngles.y + delta;
			transform.localEulerAngles = new Vector3 (rotationX, rotationY, 0);
	}

}
}
