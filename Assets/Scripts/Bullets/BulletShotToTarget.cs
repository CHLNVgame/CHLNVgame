﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShotToTarget : BulletManager {
	GameObject player;
	Vector3 shotDirection;
	// Use this for initialization
	void Start () {
		transform.Rotate (0, 0, Define.ANGLE_ROTATE_180);
		player = GameObject.FindGameObjectWithTag ("Player");
		if (player != null) {
			RotateToTarget (player);
			shotDirection = (player.transform.position - transform.position).normalized;
		} else {
			shotDirection = transform.position.normalized;
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		BulletShot ();
	}

	void RotateToTarget(GameObject objTarget)
	{
		Vector3 direction = objTarget.transform.position - transform.position;
		float angle = Mathf.Atan2 (direction.y, direction.x) * Mathf.Rad2Deg - Define.ANGLE_ROTATE_90;
		transform.rotation  = Quaternion.AngleAxis (angle, Vector3.forward);
	}

	void BulletShot()
	{
		transform.position += shotDirection * Speed * Time.deltaTime;
	}
}
