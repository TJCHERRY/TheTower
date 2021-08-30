using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navscript : MonoBehaviour {
	
	[SerializeField]
	private Transform _Destination;
	public Transform [] nextDestination;

	NavMeshAgent _navMeshAgent;

	// Use this for initialization
	void Start () {
		_navMeshAgent = this.GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (_navMeshAgent != null) {
		
			SetDestination ();
		}

		if (_navMeshAgent.remainingDistance <= 0.1f) {
			//for (int i = 0; i <= nextDestination.Length-1; i++) {
				_Destination.transform.position = nextDestination[Random.Range (0, 6)].transform.position;

			//}
		}
		Debug.Log (_Destination.transform.position);
	}

	private void SetDestination(){

		if (_Destination != null) {
		
			Vector3 targetVector = _Destination.transform.position;
			_navMeshAgent.SetDestination (targetVector);
		}



	}
}
