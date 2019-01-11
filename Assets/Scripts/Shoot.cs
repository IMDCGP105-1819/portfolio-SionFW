using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	public Transform firePoint;
	public float distance;

	public LineRenderer LineOfSight;

	// Retrieves input information
	void Update () {
		if (Input.GetButtonDown("Fire1"))
		{
			shoot();
		}
	}

	void shoot () //This is for firing the raycast and decting if it hit an enemy. If so it will apply damage and kill the enemy
	{
		RaycastHit2D hitInfo = Physics2D.Raycast (firePoint.position, firePoint.right);

		if (hitInfo) {
			Damage enemy = hitInfo.transform.GetComponent<Damage> ();
			if (enemy != null)
			enemy.Kill ();
	}
		
	}
}
	