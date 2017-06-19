using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E1 : Enemy {

	void Awake() {
		Define.DIRECTION_ENEMIES directionMove = Define.DIRECTION_ENEMIES.TOP_BOTTOM;
		if (directionMove == Define.DIRECTION_ENEMIES.TOP_BOTTOM) {
			transform.Rotate (0, 0, Define.ANGLE_ROTATE_180);
		} else if (directionMove == Define.DIRECTION_ENEMIES.RIGHT_LEFT) {
			transform.Rotate (0, 0, Define.ANGLE_ROTATE_90);
		} else if (directionMove == Define.DIRECTION_ENEMIES.LEFT_RIGHT) {
			transform.Rotate (0,0,Define.ANGLE_ROTATE_270);
		}
		Speed 	= Attributes.E1_ATT [levelEnemy - 1, Attributes.SPEED_ENEMY];
		HP 		= Attributes.E1_ATT [levelEnemy - 1, Attributes.HP_ENEMY];
		Damge   = Attributes.E1_ATT [levelEnemy - 1, Attributes.DAMGE_ENEMY];
	}


	void Start ()
	{
		Speed 	= Attributes.E1_ATT [levelEnemy - 1, Attributes.SPEED_ENEMY];
		HP 		= Attributes.E1_ATT [levelEnemy - 1, Attributes.HP_ENEMY];
		Health health = GetComponent<Health> ();
		if(health != null)
			health.SeekHealthDamge (HP, Damge);
	}

	// Update is called once per frame
	/*void Update () {
		if(Time.fixedTime > timeAction)
			DirectionMove ();
	}*/
}
