using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	float vert;
	float hor;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		vert = Input.GetAxis ("Vertical");
		bool yolo=Input.GetKey (KeyCode.X);
		hor = Input.GetAxis ("Horizontal");
		transform.Translate (0, 0, vert * 0.05f);
		transform.Rotate (0, hor*2f, 0);
	}
}
