using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapSensor : MonoBehaviour {
	RaycastHit hit;
	public GameObject Key;
	float sensorHeight=3.0f;
	public GameObject Particlu;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		Ray _mRay = new Ray (transform.position+ transform.up*0.2f,Vector3.up);

		Debug.DrawRay (transform.position+ transform.up*0.2f, Vector3.up * sensorHeight,Color.blue);
		if (Physics.Raycast (_mRay, out hit, sensorHeight)) {
			if(hit.collider.tag=="enemy") {
		
			Debug.Log (hit.collider.name);

			Destroy(hit.collider.gameObject);

				for (int i = 0; i <= 10; i++) {

					Instantiate (Particlu, hit.transform.position, Quaternion.identity);

				}

				Instantiate (Key, hit.transform.position, Quaternion.identity);
				Destroy (gameObject, 2f);
			}
		}


		

		

	}
}
