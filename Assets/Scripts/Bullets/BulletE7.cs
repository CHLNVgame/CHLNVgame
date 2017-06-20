using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletE7 : BulletManager {

	void Start () {		
	}

	// Update is called once per frame
	void Update () {
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
		Debug.Log ( " posX: "+pos.x);
		Debug.Log ( " posY: "+pos.y);
		Debug.Log ( " Speed: "+Speed);
	}
}
