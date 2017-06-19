using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : BulletManager {

	public float Angle = 0;

	void Start () {		
	}

	// Update is called once per frame
	void FixedUpdate () {
		BulletShot();
	}

	void BulletShot()
	{
		//Debug.Log ("Shot");
		//bodyBullet.velocity = new Vector2 (bodyBullet.velocity.x+0.1f, -Speed);
		Vector3 pos = transform.position;
		pos.x += Speed*Angle*Time.deltaTime;
		pos.y -= Speed*Time.deltaTime;
		transform.position = pos; 
	}
}
