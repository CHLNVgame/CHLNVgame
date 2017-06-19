using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMc01 : MonoBehaviour {
	public float Speed;
	//private float Attack;
	protected Rigidbody2D bodyBullet;

	private int damge;
	// Use this for initialization
	void Start () {
		bodyBullet = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		BulletShot ();
	}

	public void seekDamge (int amount)
	{
		damge = amount;
	}

	void OnTriggerEnter2D(Collider2D target) {
		if (target.tag == "DestroyBulletPlayer") {
			Destroy (gameObject);
		}
		if (target.tag == "Enemy" || target.tag == "Boss") {
			Destroy (gameObject);
		}
	}
	void BulletShot()
	{
		bodyBullet.velocity = new Vector2 (bodyBullet.velocity.x, Speed);
	}
}
