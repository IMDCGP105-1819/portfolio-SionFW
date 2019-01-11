using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;

	private Rigidbody2D rb;
	private Vector2 moveVelocity;

	void Start () {

		rb = GetComponent<Rigidbody2D> ();
		
	}

	void Update () {
		//Using Vectors and Unity's project settings to detect input, the code below checks for axis inputs in the Horizontal and Vertical axis. A velocity is then calculated using the Input multiplied by a speed variable
		Vector2 moveInput = new Vector2 (Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
			moveVelocity = moveInput.normalized * speed;

		Vector3 pos = transform.position;
		//Here I used .Clamp to limit the players movement to a confined space within the camera
		pos.x = Mathf.Clamp (pos.x, -16f, 16f);
		pos.y = Mathf.Clamp (pos.y, -9.1f, 9.1f);
		transform.position = pos;
	}

	void FixedUpdate() {
		//Moving the rigid body
		rb.MovePosition (rb.position + moveVelocity * Time.fixedDeltaTime);
	}
}