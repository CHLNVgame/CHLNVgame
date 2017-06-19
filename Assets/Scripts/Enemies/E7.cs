using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E7 : Enemy {
	public GameObject bulletLeftRound1;
	public GameObject bulletRightRound1;
	public GameObject bulletLeftRound2;
	public GameObject bulletRightRound2;
	public GameObject posBulletLeft;
	public GameObject posBulletRight;
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
		SpeedBulletShot = Attributes.E3_ATT [levelEnemy - 1, Attributes.SPEED_BULLET_ENEMY];
	}

	// Use this for initialization
	void Start () {
		Health health = GetComponent<Health> ();
		if(health != null)
			health.SeekHealthDamge (HP, Damge);
	}

	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad <= timeAction)
			return;
			
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
		yield return new WaitForSeconds (SpeedBulletShot);
		Instantiate (bulletLeftRound1, posBulletLeft.transform.position, Quaternion.identity);			
		Instantiate (bulletRightRound1, posBulletRight.transform.position, Quaternion.identity);
		yield return new WaitForSeconds (SpeedBulletShot);
		Instantiate (bulletLeftRound2, posBulletLeft.transform.position, Quaternion.identity);			
		Instantiate (bulletRightRound2, posBulletRight.transform.position, Quaternion.identity);
		canShoot = true;
	}
}
