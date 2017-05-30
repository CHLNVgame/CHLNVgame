using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowBullet : MonoBehaviour {
	public float Speed;
	//private float Attack;
	private Rigidbody2D bodyBullet;
	// Use this for initialization
	void Start () {
		bodyBullet = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		bodyBullet.velocity = new Vector2 (bodyBullet.velocity.x, Speed);
	}

	void OnTriggerEnter2D(Collider2D target) {
		if (target.tag == "DestroyBulletPlayer") {
			Destroy (gameObject);
		}
		if (target.tag == "Enemy") {
			Destroy (gameObject);
		}
	}
}
