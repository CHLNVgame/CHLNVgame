using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShotToBottom : BulletManager {

	void Start () {
		//bodyBullet = GetComponent<Rigidbody2D> ();
		transform.Rotate (0, 0, Define.ANGLE_ROTATE_180);
	}
	
	// Update is called once per frame
	void Update () {
		BulletShot ();
	}
	void BulletShot()
	{
	//	//Debug.Log ("Shot To Bottom");
		Vector3 pos = transform.position;
		pos.x += Speed*Angle*Time.deltaTime;
		pos.y -= Speed*Time.deltaTime;
		transform.position = pos; 
	}
}
