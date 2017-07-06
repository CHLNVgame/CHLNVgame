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
		Damge = Attributes.E5_ATT[levelEnemy - 1, Attributes.DAMGE_ENEMY];
        Bonus = Attributes.E5_ATT[levelEnemy - 1, Attributes.BONUS_ENEMY];
    }


	void Start ()
	{
		Health health = GetComponent<Health> ();
		if(health != null)
            health.SeekHealthDamge(HP, Damge, Bonus);
        float max = Speed + 1;
		float min = Speed - 1;
		Speed = Random.Range (max, min);
	}

	// Update is called once per frame
	void Update () {
			DirectionMove ();
	}

	void DirectionMove()
	{
		targetMove = transform.position;

		switch (directionMove) {
		case  Define.DIRECTION_ENEMIES.DIAGONAL_LEFTTOP_RIGHTBOTTOM:
			targetMove.x += Speed * Time.deltaTime;
			targetMove.y -= Speed*0.5f * Time.deltaTime;
			transform.position = targetMove;
			break;
		}

	}
}
