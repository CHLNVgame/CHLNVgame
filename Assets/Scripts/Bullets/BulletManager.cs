using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour {

	protected int Speed;
	private int Damge;
	private bool bulletPlayer;

	// Use this for initialization
	public void SeekSpeedDamge (int speed, int damge, bool bulletplayer) {
		Speed = speed;
		Damge = damge;
		bulletPlayer = bulletplayer;

	}
	void OnTriggerEnter2D(Collider2D target) {
		if (bulletPlayer) {
			if (target.tag == "DestroyBulletPlayer") {
				Destroy (gameObject);
			}

			if (target.tag == "Enemy" || target.tag == "Boss") {

				Health health = target.GetComponent<Health> ();
				if (health != null) {
					health.TakeDame (Damge);
				}
				Destroy (gameObject);
			}
		} else {
			if (target.tag == "Player") {
				Destroy (gameObject);
				Health health = target.GetComponent<Health> ();
				if (health != null) {
					health.TakeDame (Damge);
				}
			}
		}






	}
}
