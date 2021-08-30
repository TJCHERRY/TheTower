using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScript : MonoBehaviour {
	public Transform target;
	Vector3 currentRotation;
	Vector3 smoothVelocity;
	//public float offset;
	//Quaternion rotation;
	float x;
	float y;
	//float z=60f;
	// Use this for initialization
	void Start () {
		smoothVelocity = new Vector3 (20f,20f);
	}
	
	// Update is called once per frame
	void LateUpdate () {
		y -= Input.GetAxis ("Mouse Y");
		x += Input.GetAxis ("Mouse X");
		y = Mathf.Clamp (y, -25f, 50f);
		//Quaternion rotation = Quaternion.Euler(y, x, 0);
		//transform.rotation = rotation;
		//transform.Rotate (-y, x, z);
		//transform.position = (target.position-transform.position);
		currentRotation= Vector3.SmoothDamp(currentRotation,new Vector3(y,x),ref smoothVelocity, 0.2f);
		transform.rotation = Quaternion.Euler (currentRotation);
		//Debug.Log (transform.rotation);
		transform.position = target.position - (transform.forward*2.7f-transform.up*1f);
		Debug.DrawRay (transform.position, (transform.forward*2.7f-transform.up*1f), Color.green);
	}
}
