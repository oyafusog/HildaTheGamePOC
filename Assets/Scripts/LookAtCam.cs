using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCam : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update() {
		/*transform.LookAt(Camera.main.transform.position, -Vector3.up);
		transform.rotation.Set(0,0,transform.rotation.z,0);*/
		transform.rotation=Camera.main.transform.rotation;
	}


}
