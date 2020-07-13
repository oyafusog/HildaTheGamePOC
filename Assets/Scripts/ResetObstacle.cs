using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Script to put player back to specified position
/// 
/// </summary>
public class ResetObstacle : MonoBehaviour {
    
	public Transform reset_position; 

	void Start() {
        
    }

    void Update() {
        
    }

	void OnTriggerEnter(Collider other ) {
		if(other.CompareTag("Player")) {
			other.gameObject.transform.position = reset_position.position;
		}
	}

}
