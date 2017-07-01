using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E7 : Enemy {

	public GameObject bullet;
	public Transform[] posBullets;
	bool canShoot = true;
	void Awake() {
		Define.DIRECTION_ENEMIES directionMove = Define.DIRECTION_ENEMIES.TOP_BOTTOM;
		if (directionMove == Define.DIRECTION_ENEMIES.TOP_BOTTOM) {
			transform.Rotate (0, 0, Define.ANGLE_ROTATE_180);
		} else if (directionMove == Define.DIRECTION_ENEMIES.RIGHT_LEFT) {
			transform.Rotate (0, 0, Define.ANGLE_ROTATE_90);
		} else if (directionMove == Define.DIRECTION_ENEMIES.LEFT_RIGHT) {
			transform.Rotate (0,0,Define.ANGLE_ROTATE_270);
		}

		Speed = Attributes.E7_ATT [levelEnemy - 1, Attributes.SPEED_ENEMY];
		HP    = Attributes.E7_ATT [levelEnemy - 1, Attributes.HP_ENEMY];
		Damge = Attributes.E7_ATT[levelEnemy - 1, Attributes.DAMGE_ENEMY];
		SpeedBulletShot = Attributes.E7_ATT [levelEnemy - 1, Attributes.SPEED_BULLET_ENEMY];
		FireRate = Attributes.E7_ATT [levelEnemy - 1, Attributes.FIRE_RATE_BULLET_ENEMY];
	}

	// Use this for initialization
	void Start () {
		Health health = GetComponent<Health> ();
		if(health != null)
			health.SeekHealthDamge (HP, Damge);
	}

	// Update is called once per frame
	void Update () {
		DirectionMove ();
		EnemyShot ();
	}
	public void EnemyShot()
	{
		if(canShoot)
			StartCoroutine (shoot());
	}

	IEnumerator shoot() {
		canShoot = false;


		yield return new WaitForSeconds (FireRate);

		for (int i = 0; i < 6; i++) {
			GameObject bull = (GameObject)Instantiate (bullet, posBullets[i < 3 ? 0 : 1].transform.position, Quaternion.identity);	
			BulletManager bulletmanager = bull.GetComponent<BulletManager> ();
			if (bulletmanager != null) 
			{
				bulletmanager.SeekSpeedDamge (SpeedBulletShot, Damge, false);
				int stt = i % 3;
				if(i < 3)
					bulletmanager.SeekAngle (stt== 0 ? -0.4f : (stt == 2 ? -0.3f : -0.2f));
				else
					bulletmanager.SeekAngle (stt== 0 ? 0.4f : (stt == 2 ? 0.3f : 0.2f));
			}
		}
		yield return new WaitForSeconds (FireRate/2);

		for (int i = 0; i < 6; i++) {
			GameObject bull = (GameObject)Instantiate (bullet, posBullets[i < 3 ? 0 : 1].transform.position, Quaternion.identity);	
			BulletManager bulletmanager = bull.GetComponent<BulletManager> ();
			if (bulletmanager != null) 
			{
				bulletmanager.SeekSpeedDamge (SpeedBulletShot, Damge, false);
				int stt = i % 3;
				bulletmanager.SeekAngle (stt== 0 ? -0.07f : (stt == 2 ? 0.07f : 0f));
			}
		}
		canShoot = true;
	}
}
