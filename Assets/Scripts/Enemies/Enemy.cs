﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {
	// Properties

	[Header("Get Value From Data")]
	public float timeAction = 0f;
	[Range(1, Attributes.TOTAL_LEVEL_ENEMY)]
	public int levelEnemy = 1;
	public Define.DIRECTION_ENEMIES directionMove;


	[Header("View Value")]

	protected Transform tr_Player;
	protected Vector3 targetMove;

	protected float timeCounter;
	protected int Speed;
	protected int HP;

	// Update is called once per frame
	void Update () {
        //Debug.Log(" timeSinceLevelLoad:  " + Time.timeSinceLevelLoad);
        if (Time.timeSinceLevelLoad > timeAction)
			DirectionMove ();
	}

	protected void DirectionMove()
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
