using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour {
	public GameObject Particles;
	public GameObject Key;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col){
	
		if (col.gameObject.tag == "EnemySensor") {
		
			Destroy (gameObject);
			Instantiate (Key, col.transform.position, Quaternion.identity);
			for (int i = 0; i <= 20; i++) {

				Instantiate (Particles, col.transform.position, Quaternion.identity);

			}
			Destroy (col.gameObject);

		}
	
	}
}
