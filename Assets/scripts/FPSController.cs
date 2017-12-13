using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSController : MonoBehaviour {

	public float speed = 2.0f;
	public float lookSensitivity = 5.0f;
	//CharactorController player;

	public float moveFB;
	public float moveLR;
	public float currentXRotation;
	public float currentYRotation;
	public float xRotation;
	public float yRotation;
	public float xRotationV;
	public float yRotationV;

	public float Force = 0.3f;
	public float xForce;
	public float yForce;
	void Start () {
		//player = GetComponent<CharactorController> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log("");
		xRotation -= Input.GetAxis ("Mouse Y") * lookSensitivity;
		yRotation += Input.GetAxis ("Mouse X") * lookSensitivity;
		//xRotation = Mathf.Clamp(xRotation,-90,90);
		transform.rotation = Quaternion.Euler(xRotation,yRotation,0);

		xForce = Input.GetAxis ("Horizontal") * Force;
		yForce = Input.GetAxis ("Vertical") * Force;
		transform.Translate (new Vector3(xForce, 0, yForce));



		
	}
}
