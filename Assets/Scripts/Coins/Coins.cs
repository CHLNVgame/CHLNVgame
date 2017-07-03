using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour {
	float speed;
	public float minSpeed = 1f;
	public float maxSpeed = 2f;
	GameObject player;
	protected Vector3 targetMove;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		speed = Random.Range (minSpeed, maxSpeed);
		targetMove = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (player != null) {
			float distance = Vector3.Distance (transform.position, player.transform.position);
		//	//Debug.Log (distance);
			if (distance <= Define.DISTANCE_COIN_PLAYER) {
				speed += Define.SPEED_COIN_PLAYER;
				targetMove = Vector3.MoveTowards (transform.position, player.transform.position, speed * Time.deltaTime);
			} else {
				targetMove.y -= speed * Time.deltaTime;
			}
		} else {
			targetMove.y -= speed * Time.deltaTime;
		}
		transform.position = targetMove;
	}

	void OnTriggerEnter2D(Collider2D target) {
		if (target.tag == "Player" || target.tag == "DestroyItems") {
			Destroy (gameObject);
		}
	}
}
