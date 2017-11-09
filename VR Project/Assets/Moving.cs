using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Moving : MonoBehaviour {

	public float velocity;
	public Button myButton;
	public Vector3 startPlayerPos;

	// Use this for initialization
	void Start () {
		velocity = 0;
		myButton btn = myButton.GetComponent<myButton>();
		btn.onClick.AddListener(TaskOnClick);
/*		player = GameObject.Find ("player");
		Transform playerTransform = player.transform;
		Vector3 startPlayerPos = playerTransform.position;
		startPlayerPos = player.position;*/
	}
	
	// Update is called once per frame
	void Update () {
		
		velocity -= .01;
		transform.z = transform.z + velocity;

	}

	void TaskOnClick() {
		velocity += 3; 
	}
}
