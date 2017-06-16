﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E3 : Enemy {
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
	}


	void Start ()
	{
		Health health = GetComponent<Health> ();
		if(health != null)
			health.SetHealth (HP);
	}

	// Update is called once per frame
	void Update () {
		/*if (timeAction > 0) {
			timeAction -= Time.deltaTime;
			return;
		}*/
		if(Time.timeSinceLevelLoad > timeAction)
			DirectionMove ();
	}

	void DirectionMove()
	{

	//	Debug.Log (" Speed:  "+Speed);
		targetMove = transform.position;

		switch (directionMove) {
		case  Define.DIRECTION_ENEMIES.TOP_BOTTOM:
			targetMove.y -= Speed * Time.deltaTime;
			break;
		}
		transform.position = targetMove;
	}

}
