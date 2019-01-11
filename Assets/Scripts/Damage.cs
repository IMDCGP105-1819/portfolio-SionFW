using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour {

	public int health = 1;
	float immuneTime = 0;
	int StartLayer;

	void Start() {
		StartLayer = gameObject.layer;
	}

	void OnTriggerEnter2D(){
		Debug.Log ("Triggered");
	//This sets the object to the immune layer preventing them from taking damage momentarily
			health--;
			immuneTime = 1.25f;
		gameObject.layer = 10;
	}

	void Update() {
		//If the immune timer is at 0, this brings the player back to the original layer, allowing them to take damage.
		immuneTime -= Time.deltaTime;
		if (immuneTime <= 0) {
			gameObject.layer = StartLayer;
		}
		if (health <= 0) {
			Kill ();
		}
	}
	//Death function. If dead, game object is destroyed
	public void Kill() {
		Destroy (gameObject);
	}
}
