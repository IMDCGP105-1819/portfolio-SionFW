﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceMouse : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update ()
	{
		//This rotates the player towards the angle of the mouse, allowing it to face towards the mouse.
		var dir = Input.mousePosition - Camera.main.WorldToScreenPoint (transform.position);
		var angle = Mathf.Atan2 (dir.y, dir.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis (angle, Vector3.forward);
	}
}
