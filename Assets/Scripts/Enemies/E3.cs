using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E3 : Enemy {
	public GameObject bullet;
	public GameObject posBullet;
	bool canShoot = true;
	// Properties
	void Awake() {
		Define.DIRECTION_ENEMIES directionMove = Define.DIRECTION_ENEMIES.TOP_BOTTOM;
		if (directionMove == Define.DIRECTION_ENEMIES.TOP_BOTTOM) {
			transform.Rotate (0, 0, Define.ANGLE_ROTATE_180);
		} else if (directionMove == Define.DIRECTION_ENEMIES.RIGHT_LEFT) {
			transform.Rotate (0, 0, Define.ANGLE_ROTATE_90);
		} else if (directionMove == Define.DIRECTION_ENEMIES.LEFT_RIGHT) {
			transform.Rotate (0,0,Define.ANGLE_ROTATE_270);
		}
		Speed = Attributes.E3_ATT [levelEnemy - 1, Attributes.SPEED_ENEMY];
		HP 	  = Attributes.E3_ATT [levelEnemy - 1, Attributes.HP_ENEMY];
		Damge = Attributes.E3_ATT[levelEnemy - 1, Attributes.DAMGE_ENEMY];
        Bonus = Attributes.E3_ATT[levelEnemy - 1, Attributes.BONUS_ENEMY];
        SpeedBulletShot = Attributes.E3_ATT [levelEnemy - 1, Attributes.SPEED_BULLET_ENEMY];
		FireRate = Attributes.E3_ATT [levelEnemy - 1, Attributes.FIRE_RATE_BULLET_ENEMY];
	}


	void Start ()
	{
		Health health = GetComponent<Health> ();
		if(health != null)
            health.SeekHealthDamge(HP, Damge, Bonus);
    }

	// Update is called once per frame
	void Update () {
		DirectionMove ();
		EnemyShot ();
	}

	void DirectionMove()
	{
	//	//Debug.Log (" Speed:  "+Speed);
		targetMove = transform.position;

		switch (directionMove) {
		case  Define.DIRECTION_ENEMIES.TOP_BOTTOM:
			targetMove.y -= Speed * Time.deltaTime;
			break;
		}
		transform.position = targetMove;
	}
	public void EnemyShot()
	{
		if(canShoot)
			StartCoroutine (shoot());
	}

	IEnumerator shoot() {
		canShoot = false;
		yield return new WaitForSeconds (FireRate);
		GameObject bull = (GameObject) Instantiate (bullet, posBullet.transform.position, Quaternion.identity);	

		BulletManager bulletmanager = bull.GetComponent<BulletManager> ();
		if (bulletmanager != null) 
		{
	//		//Debug.Log (" xxxxxxxxxxxxxxxxxxxx SpeedBulletShot: "+SpeedBulletShot);
			bulletmanager.SeekSpeedDamge (SpeedBulletShot, Damge, false);
		}

		canShoot = true;
	}

}
