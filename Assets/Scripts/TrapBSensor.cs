using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapBSensor : MonoBehaviour {
	RaycastHit hit;

	float sensorHeight=5.0f;
	public GameObject Particlee;
	public GameObject Key;

	public Transform Grenade_Ref;
	Rigidbody rb;
	//bool laserSpawned= false;
	// Use this for initialization
	void Start () {
		//rb = Particlee.GetComponent<Rigidbody>();
		Debug.Log (rb);
	
	}
	
	// Update is called once per frame
	void Update () {
		//
	//	if (laserSpawned == false) {

			StartCoroutine ("LaserDraw");
		//rb.GetComponent<Rigidbody>().AddForce(0f, 70000f, 70000f,ForceMode.Impulse);
			//laserSpawned = true;
		//} 




		Debug.DrawRay (transform.localPosition, transform.forward * sensorHeight,Color.red);
	
			
		/**/
	}

	IEnumerator LaserDraw(){
		yield return new WaitForSeconds (3.3f);
		Ray _mRay = new Ray (transform.position+ transform.forward*0.2f,transform.forward);
		if (Physics.Raycast (_mRay, out hit, sensorHeight)) {
			if(hit.collider.tag=="EnemySensor") {

				Debug.Log (hit.collider.name);


				//Destroy(hit.collider.gameObject);

				//for (int i = 0; i <= 10; i++) {

				Particlee=Instantiate(Particlee, Grenade_Ref.position, Quaternion.identity) as GameObject;
				Particlee.GetComponent<Rigidbody>().AddForce(transform.forward*(190f),ForceMode.Force);
				Instantiate (Key, hit.transform.position, Quaternion.identity);
				StopAllCoroutines();

				yield break;

				//}
			}
			yield return null;
		}

	}


}
