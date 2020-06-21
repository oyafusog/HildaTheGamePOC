using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCam : MonoBehaviour {

	public GameObject follow;
	public float lerptime;

    void Start() {
        
    }


    void Update() {
        Vector3 targetpos = Vector3.Lerp(follow.transform.position,transform.position,lerptime);
		transform.position = targetpos;
    }
}
