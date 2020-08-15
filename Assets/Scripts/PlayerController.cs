using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float mvspd = 5;

	//adjusted movements
	Vector3 forward = new Vector3(-1,0,0);
	Vector3 back = new Vector3(1,0,0);
	Vector3 up = new Vector3(0,0,-1);
	Vector3 down = new Vector3(0,0,1);

	//sprite orientation
	bool mvrght = true;
	public GameObject sprite;

    private Animator animator;

    void Start() {
        animator = GetComponentInChildren<Animator>();
        animator.SetFloat("Speed", 0f);
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
        animator.SetFloat("speed", 0f);
        if (Input.GetKeyDown(KeyCode.Space)) {

		}

        if(Input.GetKey(KeyCode.RightArrow)) {
			gameObject.transform.Translate(forward*Time.deltaTime*mvspd,Space.World);
			mvrght = true;
            animator.SetFloat("speed", 2f);
		}
        if(Input.GetKey(KeyCode.LeftArrow)) {
			gameObject.transform.Translate(back*Time.deltaTime*mvspd,Space.World);
			mvrght = false;
            animator.SetFloat("speed", 2f);
        }
        if(Input.GetKey(KeyCode.UpArrow)) {
			gameObject.transform.Translate(up*Time.deltaTime*mvspd,Space.World);
            animator.SetFloat("speed", 2f);
        }
        if(Input.GetKey(KeyCode.DownArrow)) {
			gameObject.transform.Translate(down*Time.deltaTime*mvspd,Space.World);
            animator.SetFloat("speed", 2f);
        }


		SpriteDirection();
		SpriteLookAtCamera();
    }

	void SpriteLookAtCamera() {
		Vector3 correction = Camera.main.transform.eulerAngles;
		correction.y = sprite.transform.eulerAngles.y;
		if(!mvrght) {
			correction.x = correction.x*-1;
		}
		sprite.transform.eulerAngles = correction;
	}

	void SpriteDirection() {
		Debug.Log(mvrght);
		if(mvrght) {
			Vector3 orientation = sprite.transform.localEulerAngles;
			orientation.y = 180f;
			sprite.transform.eulerAngles = orientation;
		} else {
			Vector3 orientation = sprite.transform.localEulerAngles;
			orientation.y = 0;
			sprite.transform.eulerAngles = orientation;
		}
	}
}
