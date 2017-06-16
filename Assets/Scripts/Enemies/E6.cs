using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E6 : Enemy {
	// Use this for initialization
	private float timeChase = 4.0f;
	private bool activeChase = false;

	void Awake()
	{
		if (directionMove == Define.DIRECTION_ENEMIES.TOP_BOTTOM) {
			transform.Rotate (0, 0, 180f);
		} else if (directionMove == Define.DIRECTION_ENEMIES.RIGHT_LEFT) {
			transform.Rotate (0, 0, 90f);
		}
		else if (directionMove == Define.DIRECTION_ENEMIES.LEFT_RIGHT) 
		{
			transform.Rotate (0,0,270f);
		}
		Speed = Attributes.E6_ATT [levelEnemy - 1, Attributes.SPEED_ENEMY];
		HP    = Attributes.E6_ATT [levelEnemy - 1, Attributes.HP_ENEMY];
	}
	void Start () {

		Health health = GetComponent<Health> ();
		health.SetHealth (HP);

		tr_Player = GameObject.FindGameObjectWithTag ("Player").transform;
		activeChase = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (tr_Player != null &&Time.timeSinceLevelLoad > timeAction + timeChase)
			ChasePlayer ();
		else if (Time.timeSinceLevelLoad > timeAction)
			DirectionMove ();

	}

	void DirectionMove()
	{
		
	//	Debug.Log (" Speed:  "+Speed);

			targetMove = transform.position;

			switch (directionMove) {
			case  Define.DIRECTION_ENEMIES.TOP_BOTTOM:
				targetMove.x = Mathf.Cos (Time.timeSinceLevelLoad) * Speed * Time.deltaTime + transform.position.x;
				targetMove.y += Speed * Time.deltaTime;
				break;

			case Define.DIRECTION_ENEMIES.LEFT_RIGHT:
				targetMove.x += Speed * Time.deltaTime;
				targetMove.y = Mathf.Cos (Time.timeSinceLevelLoad) * Speed * Time.deltaTime + transform.position.y;
				break;

			case Define.DIRECTION_ENEMIES.RIGHT_LEFT:
				targetMove.x -= Speed * Time.deltaTime;
				targetMove.y = Mathf.Cos (Time.timeSinceLevelLoad) * Speed * Time.deltaTime + transform.position.y;
				break;
			}

			Vector3 direction = targetMove - transform.position;
			float angle = Mathf.Atan2 (direction.y, direction.x) * Mathf.Rad2Deg - 90f;
			Quaternion rotation = Quaternion.AngleAxis (angle, Vector3.forward);

			transform.rotation = Quaternion.Slerp (transform.rotation, rotation, 2 * Speed * Time.deltaTime);
			transform.position = new Vector3 (targetMove.x, targetMove.y, targetMove.z);
	}

	void ChasePlayer()
	{
		float distance = Vector3.Distance(tr_Player.position, transform.position);
	//	Debug.Log (" xxxxxxxxxxxxx  distance: "+distance);
		if (distance > 6 && activeChase) {

			Vector3 direction = tr_Player.position - transform.position;
			float angle = Mathf.Atan2 (direction.y, direction.x) * Mathf.Rad2Deg - 90f;
			Quaternion rotation = Quaternion.AngleAxis (angle, Vector3.forward);
			transform.rotation = Quaternion.Slerp (transform.rotation, rotation, Speed * Time.deltaTime);
		}
		else if (distance <= 6) 
		{
			activeChase = false;
		}
		transform.position += transform.up * Speed*3 * Time.deltaTime;
	}
}
