using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour {
	public float Speed;
	public float Angle = 0;
	//protected Rigidbody2D bodyBullet;

	// Use this for initialization
	void Start () {		
	}

	// Update is called once per frame
	void FixedUpdate () {
		BulletShot();
	}
	void OnTriggerEnter2D(Collider2D target) {
		if (target.tag == "Player") {
			Destroy (gameObject);
			Destroy (target.gameObject);
		}
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
