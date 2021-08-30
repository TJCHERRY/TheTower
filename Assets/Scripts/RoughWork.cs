using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoughWork : MonoBehaviour {
	//static int num;
	//GameObject obj;


	//public enum _PrimitiveType{
		//Sphere,Capsule,Cube,Cylinder,Plane
	//}
	//public _PrimitiveType _primitiveType;
	// Use this for initialization
	void Start () {
		float angle = Mathf.Atan2 (1.0f, 0f)+2*Mathf.PI;
		Debug.Log(angle*Mathf.Rad2Deg);
		Debug.Log (Mathf.Abs(-10.05f));

//		obj = GameObject.CreatePrimitive (_primitiveType);
		//Debug.Log(num);
	}
	
	// Update is called once per frame
	void Update () {
		//TESTING ENUMS
		/*if (_primitiveType == _PrimitiveType.Sphere) {
			obj = GameObject.CreatePrimitive (PrimitiveType.Sphere);
			obj.transform.position = gameObject.transform.forward * 5f;

		}

		if (_primitiveType == _PrimitiveType.Cube) {
			obj = GameObject.CreatePrimitive (PrimitiveType.Cube);
			obj.transform.position = gameObject.transform.forward * 5f;
			print("its a cube");
		}*/

		
	}

	//public static void Numcount(){

		//Debug.Log (num);
	//}
}
