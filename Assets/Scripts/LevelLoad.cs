﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoad : MonoBehaviour {

	public GameObject Lev2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider col){
	
		if (col.gameObject.tag == "Player") {
		
			Lev2.SetActive(true);
		
		
		}
	
	
	}
}
