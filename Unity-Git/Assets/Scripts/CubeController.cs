using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Move();

    }

    void Move()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("<color=darkblue>Key>>>A</color>");
        }
    }
}
