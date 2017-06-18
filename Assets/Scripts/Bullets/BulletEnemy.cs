using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour {
	public float speed;
	private Rigidbody2D bodyBullet;
	GameObject player;
	Vector3 posPlayer;
	Vector3 moveDirection;
	// Use this for initialization
	void Start () {
		bodyBullet = GetComponent<Rigidbody2D> ();
		transform.Rotate (0, 0, Define.ANGLE_ROTATE_180);
		player = GameObject.FindGameObjectWithTag ("Player");
		RotateToTarget (player);
		posPlayer = player.transform.position;
		moveDirection = (posPlayer-transform.position).normalized;
	}

	// Update is called once per frame
	void FixedUpdate () {
		//bodyBullet.velocity = new Vector2 (bodyBullet.velocity.x, -speed);

		transform.position += moveDirection * speed * Time.deltaTime;
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
	void RotateToTarget(GameObject objTarget)
	{
		Vector3 direction = objTarget.transform.position - transform.position;
		float angle = Mathf.Atan2 (direction.y, direction.x) * Mathf.Rad2Deg - Define.ANGLE_ROTATE_90;
		transform.rotation  = Quaternion.AngleAxis (angle, Vector3.forward);
	}
}
