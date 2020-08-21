using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Slows objects with "Player" within the trigger
/// and keeps the cloudmesh following the player with y offset
/// </summary>
 
public class Cloud : MonoBehaviour {
    //used to keep transform of the player while in the trigger
	public Transform  follow;
	//the cloud's movement speed
	public float      spd;
	//how far above the transfrom to follow by, 0 means the same space as the target
	public float      yoffset;
	//Put the cloud sprite here
	public GameObject cloudmesh;

	//used to store current player speed
	       float savedspd;
	public float slow_speed;


	void Start() {
		if(cloudmesh is null) {
			Debug.LogError(gameObject+ " needs a cloud object to move!\n");
		}
	}

	void Update() {

		if(follow != null) {	
			Vector3 moveto = follow.position-cloudmesh.transform.position;//find magnitude
			moveto.y = follow.position.y+yoffset-cloudmesh.transform.position.y;//use offset of y to put cloud above player
			cloudmesh.transform.Translate( moveto * spd * Time.deltaTime, Space.World);//translate
		}

    }

	void Flip() {
		cloudmesh.transform.RotateAround(cloudmesh.transform.position,cloudmesh.transform.up,180f);
	}


	void SlowTarget() {
		if(follow!=null) {
			//Get interface or script here and change hildas spd
			savedspd = follow.gameObject.GetComponent<PlayerController>().mvspd;
			follow.gameObject.GetComponent<PlayerController>().mvspd = slow_speed;
		}
	}

	void UnSlowTarget() {
		if(follow!=null) {
			//Get interface or script here and change hildas spd
			follow.gameObject.GetComponent<PlayerController>().mvspd = savedspd;
		}
	}

    void OnTriggerEnter(Collider other) {
		if(other.CompareTag("Player")) {
			follow = other.transform;
			SlowTarget();
		}
	}

    void OnTriggerStay(Collider other) {
		if(other.CompareTag("Player")) {
			follow = other.transform;
		}
	}

    void OnTriggerExit(Collider other) {
		if(other.CompareTag("Player")) {
			UnSlowTarget();
			follow = null;
		}
	}

}
