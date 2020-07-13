using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour {

	public float _X;
	public float _Y;
	float OffsetX; 
	float OffsetY; 
    void Update() {
        OffsetX += Time.deltaTime * _X;
        OffsetY += Time.deltaTime * _Y;
		GetComponent<Renderer>().material.mainTextureOffset = new Vector2(OffsetX ,OffsetY);
    }
}
