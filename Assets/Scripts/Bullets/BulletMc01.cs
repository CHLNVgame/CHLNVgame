using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMc01 : BulletManager {
	

	protected Rigidbody2D bodyBullet;

	void Start () {
		bodyBullet = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		BulletShot ();
	}

	void BulletShot()
	{
		bodyBullet.velocity = new Vector2 (bodyBullet.velocity.x, Speed);
	}
}
