using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 vec = new Vector3(Mathf.Clamp(transform.position.x, -4.0f, 4.0f), 
			Mathf.Clamp(transform.position.y, 3.5f, 8.5f), 0.0f);
	
	}
		
}
