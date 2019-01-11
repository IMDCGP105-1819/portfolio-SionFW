using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour {
	private Vector2 screenBounds;
	private float objectWidth;
	private float objectHeight;

	// This uses the camera to dictate the area of play, limiting the player from going off screen, firstly it starts by getting the object width and height by dividing the bounds of the sprite by 2
	//it then uses .Clamp with the variables, viewPos, screenbounds, objecthight and objectwidth to calculate the borders of the game.
	void Start () {
		screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
		objectWidth = transform.GetComponent<SpriteRenderer>().bounds.size.x / 2;
		objectHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;
	}

	// Update is called once per frame
	void LateUpdate(){
		Vector3 viewPos = transform.position;
		viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x + objectWidth, screenBounds.x * -1 - objectWidth);
		viewPos.y = Mathf.Clamp(viewPos.y, screenBounds.y + objectHeight, screenBounds.y * -1 - objectHeight);
		transform.position = viewPos;
	}
}
