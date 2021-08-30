using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TRoughWork : MonoBehaviour {
	public Transform target;
	public float smoothTime = 0.3F;
	Vector3 relativePos= new Vector3();

	// Use this for initialization
	void Start () {
		
		int i = 20;
		Debug.Log ("i was"+" "+ i);
		yolo (ref i);
		Debug.Log ("i is"+" "+ i);
	}
	
	// Update is called once per frame

	private Vector3 velocity = new Vector3(10f, 2f, 0f);
	private Vector3 scaleVelocity = new Vector3 (0.2f, 0.3f, 0.2f);

	void Update() {
		Vector3 targetPosition = target.position;
		transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime,5f);
		//print ("old"+ " "+ scaleVelocity);
		transform.localScale = Vector3.SmoothDamp (transform.localScale, new Vector3 (2f, 2f, 1.2f), ref scaleVelocity, smoothTime,5f);
		//print ("new" + " " +scaleVelocity);
		relativePos= target.position-transform.position;
		transform.rotation = Quaternion.LookRotation (relativePos);

	}

	public static void  yolo(ref int j){
		j = 100;
		//return j;
	}
}