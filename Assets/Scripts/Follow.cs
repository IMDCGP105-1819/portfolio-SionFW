using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {

	public GameObject target;
	public float moveSpeed;
	public float rotationSpeed;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		//Moves towards the target at its assigned move speed at a vector of it's postion and their position
		transform.position = Vector3.MoveTowards(transform.position, target.transform.position, moveSpeed * Time.deltaTime);
		//To calculate the enemy looking at the player. 
		Vector3 vectorToTarget = target.transform.position - transform.position;
		float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
		Quaternion qt = Quaternion.AngleAxis(angle, Vector3.forward);
		transform.rotation = Quaternion.RotateTowards(transform.rotation, qt, Time.deltaTime * rotationSpeed);
	}
}