using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyScript : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col){
	
		if (col.gameObject.tag == "Player") {

			PlayerMove._keyCount++;
			//
			Destroy (gameObject);
		}
	
	}
}
