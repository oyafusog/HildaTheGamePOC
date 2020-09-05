using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float mvspd = 5;
    public float jumpHeight = 2;

	//adjusted movements
	Vector3 forward = new Vector3(-1,0,0);
	Vector3 back = new Vector3(1,0,0);
	Vector3 up = new Vector3(0,0,-1);
	Vector3 down = new Vector3(0,0,1);
    Vector3 jump = new Vector3(0, 50, 0);

	//sprite orientation
	bool mvrght = true;
	public GameObject sprite;

    //sprite senses
    bool isJumping = false;
    Rigidbody rigidbody;
    private Animator animator;

    void Start() {
        animator = GetComponentInChildren<Animator>();
        animator.SetFloat("Speed", 0f);
        animator.SetBool("jump", false);
        rigidbody = GetComponent<Rigidbody>();
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
        
        //gameObject.transform.Translate(jump * Time.deltaTime * mvspd, Space.World);

        if(sprite.transform.position.y < jump.y)
        {
            animator.SetBool("jump", false);
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            if( rigidbody.velocity.y == 0)
            {
                animator.SetBool("jump", true);
                //gameObject.transform.Translate(jump * Time.deltaTime * mvspd, Space.World);
                rigidbody.velocity = Vector3.up * jumpHeight;// * Time.deltaTime;
            }
            
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
