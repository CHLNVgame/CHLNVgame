using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E4 : Enemy {
	void Awake() {
		if (directionMove == Define.DIRECTION_ENEMIES.TOP_BOTTOM) {
			transform.Rotate (0, 0, Define.ANGLE_ROTATE_180);
		} else if (directionMove == Define.DIRECTION_ENEMIES.RIGHT_LEFT) {
			transform.Rotate (0, 0, Define.ANGLE_ROTATE_90);
		} else if (directionMove == Define.DIRECTION_ENEMIES.LEFT_RIGHT) {
			transform.Rotate (0,0,Define.ANGLE_ROTATE_270);
		}
		Speed = Attributes.E4_ATT [levelEnemy - 1, Attributes.SPEED_ENEMY];
		HP    = Attributes.E4_ATT [levelEnemy - 1, Attributes.HP_ENEMY];
	}
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	/*
	void Update () {
		if(Time.timeSinceLevelLoad > timeAction)
			DirectionMove ();
	}*/
}
