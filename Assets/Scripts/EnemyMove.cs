using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {
	public Transform PointA;
	public Transform PointB;

	public float speed;
	public static int num = 20;
	GameObject player;
//	Vector3 pos;
	//bool posSwitch=false;
	// Use this for initialization
	void Start () {
		transform.position = PointA.position;
		//pos = transform.position;
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (player);
		Vector3 direction = (player.transform.position - gameObject.transform.position).normalized;
		//Debug.Log (direction);

		float distance = (player.transform.position - gameObject.transform.position).magnitude;
		//Debug.Log (distance);
		//float step = speed * Time.deltaTime;

		//void OnTriggerEnter(Collider col){
			//transform.position = Vector3.MoveTowards (transform.position, PointB.position, step);
		//}

		//else if (transform.position.x <= PointB.position.x) {
		
		transform.position = Vector3.Lerp (PointA.position, PointB.position, Mathf.PingPong (Time.time/speed, 1));


		//}
		}


	}

