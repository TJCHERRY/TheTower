using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour {
	//public Transform _endPoint;
	Animation _liFt;

	//Vector3 velocity;
	// Use this for initialization
	void Start () {
		_liFt = GetComponent<Animation> ();
	}
	
	// Update is called once per frame

	void OnTriggerEnter(Collider other){
	
		if (other.gameObject.tag == "Player") {
			_liFt.Play ("Lift");
		

		}
	
	}
}
