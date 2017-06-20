using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour {
	float speed;
	public float minSpeed = 0.1f;
	public float maxSpeed = 1f;
	GameObject player;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		speed = Random.Range (minSpeed, maxSpeed);
	}
	
	// Update is called once per frame
	void Update () {
		
		if (player != null) {
			float distance = Vector3.Distance (transform.position, player.transform.position);
		//	//Debug.Log (distance);
			if (distance <= Define.DISTANCE_COIN_PLAYER) {
				speed += Define.SPEED_COIN_PLAYER;
				transform.position = Vector3.MoveTowards (transform.position, player.transform.position, speed * Time.deltaTime);
			} else {
				transform.position -= Vector3.up * speed * Time.deltaTime;
			}
		} else {
			transform.position -= Vector3.up * speed * Time.deltaTime;
		}
	}

	void OnTriggerEnter2D(Collider2D target) {
		if (target.tag == "Player") {
			Destroy (gameObject);
		}
	}
}
