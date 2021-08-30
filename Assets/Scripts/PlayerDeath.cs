using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour {
   // Animation death;
   // public Behaviour[] _Deactivate;
   // Animator anim;
	public GameObject instructionsPanel;
    private void Start()
    {
        
        //death = GetComponent<Animation>();
       
    }
    private void Update()
    {

		if (Input.GetKey(KeyCode.Tab)) {
		
			instructionsPanel.SetActive (true);
		
		}
		else{

			instructionsPanel.SetActive (false);
		}
        
    }
    // UsAnimatione this for initialization
  /*  private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EnemySensor")
        {
           // anim = null;
            // Destroy(gameObject);
            death.Play("PlayaDeath");
            DisableBeh(false);
        }
    }*/

    /*void DisableBeh(bool value)
    {
        for (int i = 0; i < _Deactivate.Length; i++)
        {
            _Deactivate[i].enabled = value;
        }
    }*/

    public void Restart()
    {
        //DisableBeh(true);

		SceneManager.LoadScene ("sp$4_L1");
    }

	public void Quit(){

		Application.Quit();
	}



}
