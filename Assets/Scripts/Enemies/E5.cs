using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E5 : Enemy {
	
	void Awake() {
		if (directionMove == Define.DIRECTION_ENEMIES.DIAGONAL_LEFTTOP_RIGHTBOTTOM) {
			transform.Rotate (0, 0, Define.ANGLE_ROTATE_225);
		}
		Speed = Attributes.E5_ATT [levelEnemy - 1, Attributes.SPEED_ENEMY];
		HP    = Attributes.E5_ATT [levelEnemy - 1, Attributes.HP_ENEMY];
	}


	void Start ()
	{
		Health health = GetComponent<Health> ();
		if(health != null)
			health.SetHealth (HP);
	}

	// Update is called once per frame
	void Update () {
		if(Time.timeSinceLevelLoad > timeAction)
			DirectionMove ();
	}

	void DirectionMove()
	{
		targetMove = transform.position;

		switch (directionMove) {
		case  Define.DIRECTION_ENEMIES.DIAGONAL_LEFTTOP_RIGHTBOTTOM:
			targetMove.x += Speed * Time.deltaTime;
			targetMove.y -= Speed * Time.deltaTime;
			transform.position = targetMove;
			break;
		}

	}
}
