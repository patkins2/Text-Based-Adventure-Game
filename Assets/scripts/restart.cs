using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            Application.LoadLevel(0);
        }
        if(Input.GetKeyDown(KeyCode.F2))
        {
            Application.LoadLevel(1);
        }
        if(Input.GetKeyDown(KeyCode.F3))
        {
            Application.Quit();
        }
    }
}
