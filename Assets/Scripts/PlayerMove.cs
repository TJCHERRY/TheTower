using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour {
    public Behaviour[] _Deactivate;
    public static int _keyCount = 1;
	public GameObject PlayerCam;
	public GameObject reloadPanel;
	public GameObject gamePanel;
	public GameObject Testwall;
	public Text keyCount;
	Animator anim;
    bool death;
	float walkSpeed=2f;
	float runSpeed= 6f;
	public float smoothTime= 0.1f;
	float currentSpeed;
	float smoothSpeedTime= 0.1f;
	float smoothVel;
	float turnSmoothVelocity;

	Vector2 mouseActive;
	public enum _PlayerMovestate
	{
     Idol,Walk,Turn_left,Turn_Right,Sprint,Crouch,CrouchWalk,TakeCover,ExitCover,Craft
	}
	public _PlayerMovestate _moveState;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		_moveState = _PlayerMovestate.Idol;



	}
	
	// Update is called once per frame
	void Update () {



		if (_keyCount <= 0) {
		
			_keyCount = 0;
		}

       

        
		keyCount.text = "Key Count:" + _keyCount.ToString();
		//mouseActive = new Vector2 (Input.GetAxis ("Mouse X"), Input.GetAxis ("Mouse Y"));
		//Quaternion playerTargetRot;


		//transform.rotation = Quaternion.Lerp (transform.rotation, playerTargetRot,1f);


		
			//Vector2 _Input = new Vector2 ( Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw ("Vertical"));
		//transform.eulerAngles= new Vector3(0,, 0);
		//seting magnitude to one
	//Vector2 inputDirection= _Input.normalized;
	//	float targetRotation= Mathf.Atan2 (inputDirection.x, inputDirection.y) * Mathf.Rad2Deg;


		/*bool running = Input.GetKey (KeyCode.LeftShift);
		float targetSpeed = ((running) ? runSpeed : walkSpeed)* inputDirection.magnitude;
		currentSpeed = Mathf.SmoothDamp (currentSpeed, targetSpeed, ref smoothVel, smoothSpeedTime);
		transform.Translate (transform.forward * currentSpeed * Time.deltaTime, Space.World);

		float animationSpeedLevel = ((running) ? 1f : 0.5f)*inputDirection.magnitude;
		anim.SetFloat ("SpeedLevel", animationSpeedLevel,smoothSpeedTime,Time.deltaTime);*/

		float _vert = Input.GetAxis ("Vertical");
		float _hor = Input.GetAxis ("Horizontal");

		bool running = Input.GetKey(KeyCode.LeftShift);
		bool isCrouching = false;
		//bool crouchWalking=Input.GetAxis ("Vertical");
		//float crouchSpeed = (crouchWalking) ? 2f : 0f;
		float targetSpeed = (running) ? 6f : 2f;
		//Vector3 rot = new Vector3 (0, _hor, 0);

		switch (_moveState) {
		case _PlayerMovestate.Walk:
                //targetSpeed = 2f;
                if (!death)
                {
                    currentSpeed = Mathf.SmoothDamp(currentSpeed, targetSpeed, ref smoothVel, smoothSpeedTime);
                    transform.Translate(transform.forward * currentSpeed * Time.deltaTime, Space.World);

                    anim.SetFloat("SpeedLevelX", 0.2f, smoothSpeedTime, Time.deltaTime);
                }
			break;
		
		case  _PlayerMovestate.Idol: 
			//isCrouching = false;

			anim.SetFloat ("SpeedLevelX", -0.1f, smoothSpeedTime, Time.deltaTime);

		
			break;
			 
		case _PlayerMovestate.Sprint:
			//targetSpeed = 6f;
			currentSpeed = Mathf.SmoothDamp (currentSpeed, targetSpeed, ref smoothVel, smoothSpeedTime);
			transform.Translate (transform.forward * _vert * currentSpeed * Time.deltaTime, Space.World);

			//anim.SetFloat ("SpeedLevel", 1.0f, smoothSpeedTime/**inputDirection.magnitude*/, Time.deltaTime);
			anim.SetFloat ("SpeedLevelX", 0.6f, smoothSpeedTime, Time.deltaTime);

			//print ("He's Running");

			break;
		/*case _PlayerMovestate.Turn_left:
			
			//transform.eulerAngles= Vector3.up* Mathf.SmoothDampAngle(transform.eulerAngles.y,Mathf.Atan2(-1.0f,0.0f)*Mathf.Rad2Deg ,ref turnSmoothVelocity,smoothTime);
				if (inputDirection != Vector2.zero) {
					transform.eulerAngles = Vector3.up * Mathf.SmoothDampAngle (transform.eulerAngles.y, targetRotation, ref turnSmoothVelocity, smoothTime);
					anim.SetFloat ("SpeedLevel", 0.5f, smoothSpeedTime, Time.deltaTime);
					transform.Translate (transform.forward * currentSpeed * Time.deltaTime, Space.World);
			
			}
			break;*/

	/*	case _PlayerMovestate.Crouch:
			isCrouching = true;

			//transform.Translate (transform.forward * _vert * currentSpeed * Time.deltaTime, Space.World);
			//currentSpeed = Mathf.SmoothDamp (currentSpeed, targetSpeed, ref smoothVel, smoothSpeedTime);
			anim.SetFloat ("Crouchspeed", 0.2f, smoothSpeedTime/**inputDirection.magnitude, Time.deltaTime);
			anim.SetFloat ("SpeedLevelX", 0.1f, smoothSpeedTime, Time.deltaTime);

			break;

		case _PlayerMovestate.CrouchWalk:
			
			transform.Translate (transform.forward * _vert * 2f * Time.deltaTime, Space.World);
			anim.SetFloat ("crouchMove", 1.0f, smoothSpeedTime, Time.deltaTime);
			break;*/

		/*case _PlayerMovestate.TakeCover:
			anim.SetFloat ("coverVar", 0.2f, smoothSpeedTime, Time.deltaTime);

				Vector3 targetAngle= new Vector3(0,Testwall.transform.eulerAngles.y+180f,0);
				Quaternion _targetAngle = Quaternion.Euler (targetAngle);
				transform.rotation = Quaternion.Slerp(transform.rotation,_targetAngle,0.2f);
				break;

		case _PlayerMovestate.ExitCover:
			anim.SetFloat ("coverVar", -0.2f, smoothSpeedTime, Time.deltaTime);
				Vector3 targetAnglE= new Vector3(0,Testwall.transform.eulerAngles.y,0);
				Quaternion _targetAnglE = Quaternion.Euler (targetAnglE);
				transform.rotation = Quaternion.Slerp(transform.rotation,_targetAnglE,0.2f);
			break;*/

		case _PlayerMovestate.Craft:
			TrapGenerate.trapGenerating = true;
			Debug.Log (TrapGenerate.trapGenerating);
			break;
		
	}

		//---------------------------------------------------------------------------------------------------------------------------------------------------------------
		if (_moveState ==_PlayerMovestate.Idol) {

			

			if (_vert != 0) {
				transform.eulerAngles = Vector3.up*Mathf.SmoothDampAngle (transform.eulerAngles.y, Mathf.Atan2(0.0f,1.0f)*Mathf.Rad2Deg, ref turnSmoothVelocity, smoothTime);
			_moveState = _PlayerMovestate.Walk;

			}
		}


		


		if(_moveState== _PlayerMovestate.Walk){
			if (running == true) {
				
				_moveState = _PlayerMovestate.Sprint;

				/*if (isCrouching == true) {
				
					_moveState = _PlayerMovestate.CrouchWalk;
				}*/
			
			} 
			

		} 

		if (_moveState == _PlayerMovestate.Sprint) {
		
			if (running == false) {
				_moveState = _PlayerMovestate.Walk;
				
			}
		}
	else if(_vert==0){_moveState = _PlayerMovestate.Idol;}

		/*if (mouseActive == Vector2.zero) {
		
			_moveState=_PlayerMovestate.Turn_left;
		}*/

		if (_moveState != _PlayerMovestate.Idol) {
			
					Vector3 targetAngle = new Vector3 (0, PlayerCam.transform.eulerAngles.y, 0);
					Quaternion _targetAngle = Quaternion.Euler (targetAngle);
					transform.rotation = Quaternion.Slerp (transform.rotation, _targetAngle, 0.2f);
		}

				if ((Input.GetKey(KeyCode.F))||(Input.GetKey(KeyCode.G))) {
		
			_moveState = _PlayerMovestate.Craft; 	
				
				
				}

		

	

	/*	switch (isCrouching) {
		case false:
			if (Input.GetKey (KeyCode.C)) {
				_moveState = _PlayerMovestate.Crouch;
				isCrouching = true;
			}
			break;
		case true:
			if (Input.GetKey (KeyCode.C)) {
				_moveState = _PlayerMovestate.Idol;
				anim.SetFloat ("Crouchspeed", -0.1f, smoothSpeedTime, Time.deltaTime);
			}
			break;
		}*/


		
		

			


		

	/*	Vector3 rot = new Vector3 (0, _hor, 0);
		transform.eulerAngles = rot;
		transform.Translate(0,0,_vert*0.08f);

		if (_vert != 0) {
			transform.Rotate (0, _hor * 2f, 0);
			bool _running = Input.GetKey (KeyCode.LeftShift);
			float _targetSpeed = ((_running) ? runSpeed : walkSpeed);
			currentSpeed = Mathf.SmoothDamp (currentSpeed, _targetSpeed, ref smoothVel, smoothSpeedTime);
			transform.Translate (transform.forward * _vert * currentSpeed * Time.deltaTime, Space.World);
	
			float animationSpeedLevel = ((_running) ? 1.0f : 0.5f);
			anim.SetFloat ("SpeedLevel", animationSpeedLevel, smoothSpeedTime, Time.deltaTime);

		}
		else{anim.SetFloat ("SpeedLevel", 0.0f, smoothSpeedTime, Time.deltaTime);}*/
		//----------------------------------------------------------------------------------


			/*if (Input.GetKey (KeyCode.C)) {
				anim.SetFloat ("Crouchspeed", 0.5f);
			//RoughWork.Numcount ();
			}

			if (Input.GetKeyUp (KeyCode.C)) {
				anim.SetFloat ("Crouchspeed", 0.0f);
			}

		bool crouch = Input.GetKey (KeyCode.C);

		if (crouch == true && _vert != 0) {
			

				anim.SetFloat ("crouchMove", 1.0f, smoothSpeedTime, Time.deltaTime);
				
		

	}*/
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EnemySensor")
        {
            DisableBeh(true);
            death = true;
            anim.SetBool("Deathanim", death);
            transform.GetComponent<PlayerMove>().enabled=false;
						reloadPanel.SetActive(true);

						gamePanel.SetActive (false);
        }
    }

    void DisableBeh(bool value)
    {
        for (int i = 0; i < _Deactivate.Length; i++)
        {
            _Deactivate[i].enabled = value;
        }
    }
}





