﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody2D rigidBody2d;

	// Use this for initialization
	void Start () {
		rigidBody2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis("horizontal");
		float moveVertical = Input.GetAxis("vertical");
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		rigidBody2d.AddForce (movement);
	}
}
