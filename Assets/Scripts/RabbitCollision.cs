using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitCollision : MonoBehaviour {





	void OnCollisionEnter(Collision other) {
		if (other.gameObject.CompareTag("Player")) {
			//Do something
			//There is no "damage system yet
			Debug.Log(gameObject.name + " : RabbitCollision :: Hit Hilda\n" +
											"need more scraps");
			GameObject.Destroy(this.gameObject);
		}
		//ok for now, try pooling the rabbits in the future
		
	}


}
