using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitFire : MonoBehaviour {

	public GameObject[] rabbitsprefab;

	public float rabbitforce;

	void Start(){
		///derp dont do this
        //GameObject r =  GameObject.Instantiate( rabbitsprefab[ (int)(Random.value*3)] );
    }

	void OnTriggerEnter(Collider other) {
		if(other.CompareTag("Player")) {
			Vector3 dir = other.gameObject.transform.position - transform.position;
			GameObject r =  GameObject.Instantiate( rabbitsprefab[ (int)(Random.value*rabbitsprefab.Length)] );
			r.transform.position = transform.position;
			r.GetComponent<Rigidbody>().AddForce(dir.normalized * rabbitforce);;
		} 
	}

}
