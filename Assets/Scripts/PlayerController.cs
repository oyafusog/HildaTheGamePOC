﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


	public float mvspd = 5;

	Vector3 forward = new Vector3(-1,0,0);
	Vector3 back = new Vector3(1,0,0);
	Vector3 up = new Vector3(0,0,-1);
	Vector3 down = new Vector3(0,0,1);

    void Start() {
        
    }


    void Update() {

		if(Input.GetKeyDown(KeyCode.Q)) {
			//Camera.main.transform.Translate( Camera.main.transform.forward *Time.deltaTime,Space.World);
			Camera.main.orthographicSize *= .9f;
		}
		if(Input.GetKeyDown(KeyCode.W)) {
			//Camera.main.transform.Translate( -Camera.main.transform.forward *Time.deltaTime,Space.World);
			Camera.main.orthographicSize *= 1.1f;
		}

		if(Input.GetKeyDown(KeyCode.Space)) {

		}

        if(Input.GetKey(KeyCode.RightArrow)) {
			gameObject.transform.Translate(forward*Time.deltaTime*mvspd,Space.World);
		}
        if(Input.GetKey(KeyCode.LeftArrow)) {
			gameObject.transform.Translate(back*Time.deltaTime*mvspd,Space.World);
		}
        if(Input.GetKey(KeyCode.UpArrow)) {
			gameObject.transform.Translate(up*Time.deltaTime*mvspd,Space.World);
		}
        if(Input.GetKey(KeyCode.DownArrow)) {
			gameObject.transform.Translate(down*Time.deltaTime*mvspd,Space.World);
		}
    }
}
