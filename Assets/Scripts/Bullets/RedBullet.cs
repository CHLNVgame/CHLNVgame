using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBullet : MonoBehaviour {
	public float speed;
	private Rigidbody2D bodyBullet;
	// Use this for initialization
	void Start () {
		bodyBullet = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		bodyBullet.velocity = new Vector2 (bodyBullet.velocity.x, -speed);
	}
	void OnTriggerEnter2D(Collider2D target) {
		/*if (target.tag == "Destroy") {
			Destroy (gameObject);
		}*/

		if (target.tag == "Player") {
			Destroy (gameObject);
			Destroy (target.gameObject);
		}
	}
}
