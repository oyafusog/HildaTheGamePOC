using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTimer : MonoBehaviour {

	public float die;
	float awaketime;
	void Awake() {
		if(die<=0) {
			Debug.LogError(gameObject.name + " :: NEEDS DIE TIME > 0");
		}
		awaketime = 0f;
	}

    // Update is called once per frame
    void Update() {
        awaketime +=Time.deltaTime;
		if(awaketime >= die) {
			GameObject.Destroy(this.gameObject);
		}
    }
}
