using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrapGenerate : MonoBehaviour {
	GameObject CurrentTrap;
	public GameObject TrapA;
	public GameObject TrapB;
	public Image trapA_Image;
	public Image trapB_Image;
	public Text trapA;
	public Text trapB;
	Animator anim;
//	Animation trapAnim;
	// Use this for initialization
	public static bool trapGenerating= false;
	void Start () {
		
		//trapAnim = GetComponent<Animation> ();
		anim = GetComponent<Animator>();
		//trapA_Image.GetComponentInChildren<Text> ();
		//trapB_Image.GetComponentInChildren<Text> ();
		CurrentTrap= TrapA;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.anyKey) {
			switch (Input.inputString) {
			case "1":
				Debug.Log ("1 is Pressed");
				CurrentTrap = TrapA;
				trapA_Image.enabled = true;
				trapA.enabled = true;
				trapB.enabled = false;

				trapB_Image.enabled = false;

				break;
			case "2":
				CurrentTrap = TrapB;
				trapA_Image.enabled = false;
				trapA.enabled = false;
				trapB.enabled = true;
				trapB_Image.enabled = true;

				break;
			}
		}

		
		if (trapGenerating == true) {
			if (Input.GetKeyDown (KeyCode.F)) {
			

				StartCoroutine ("BuildTrapA");
			}

			/*if (Input.GetKeyDown (KeyCode.G)) {


				StartCoroutine ("BuildTrapB");
			}*/

		}


	}

	IEnumerator BuildTrapA(){
		Vector3 targetPosition = transform.localPosition+ transform.forward*0.5f +transform.up*0.15f ;
		anim.SetTrigger ("craft");

		yield return new WaitForSeconds(3.1f);
		Instantiate (CurrentTrap, targetPosition, transform.rotation);
		trapGenerating = false;
	//	yield return new WaitForSeconds(1f);
		//trapAnim.Play ();

		yield return null;
	}

	/*IEnumerator BuildTrapB(){
		Vector3 targetPosition = transform.localPosition+ transform.forward*0.6f +transform.up*0.15f ;
		anim.SetTrigger ("craft");
		yield return new WaitForSeconds(6.2f);
		Instantiate (CurrentTrap, targetPosition ,transform.rotation);
		trapGenerating = false;

		yield return null;
	}*/
}
