using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L2Door : MonoBehaviour
{
    Animation _l2Door;
    // Use this for initialization
    void Start()
    {
        _l2Door = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_l2Door != null) {


            Debug.Log("YOLO!!!!!!!!!!!!!");

        }
    }


    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "Player")
        {
           // if (PlayerMove._keyCount >= 1)
           // {
			_l2Door["L2Door"].speed = 1f;
			//_l2Door["L2Door"].time = 0.5f;
                _l2Door.Play("L2Door");

           // }

            // if (PlayerMove._keyCount <= 0)
            // {

            //  Locked.enabled = true;
            //  locked_Text.enabled = true;
            //  }
        }

    }


    void OnTriggerExit(Collider col)
    {

        if (col.gameObject.tag == "Player")
        {
           // PlayerMove._keyCount--;
            _l2Door["L2Door"].speed = -0.5f;
          _l2Door["L2Door"].time = 0.5f;
            _l2Door.Play("L2Door");


            // Locked.enabled = false;
            //  locked_Text.enabled = false;

        }
    }
}
