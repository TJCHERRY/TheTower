using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorScript : MonoBehaviour {
	Animation doorMov;
	public Image Locked;
	public Text locked_Text;
	// Use this for initialization
	void Start () {
		doorMov = GetComponent<Animation> ();
		if (doorMov != null) {
			Debug.Log ("Component Exists");
			Locked.enabled = false;
			locked_Text.enabled = false;
		
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){
	
		if (col.gameObject.tag == "Player") {
			if (PlayerMove._keyCount >= 1) {
				doorMov["Door"].speed=1;
				doorMov.Play ("Door");

			}

			if (PlayerMove._keyCount <= 0) {
			
				Locked.enabled = true;
				locked_Text.enabled = true;
			}
		}
	
	}


	void OnTriggerExit(Collider col){

		if (col.gameObject.tag == "Player") {
			PlayerMove._keyCount--;
			doorMov["Door"].speed=-1;
			doorMov ["Door"].time = 0.5f;
			doorMov.Play ("Door");
			Locked.enabled = false;
			locked_Text.enabled = false;

		}
	}
}
