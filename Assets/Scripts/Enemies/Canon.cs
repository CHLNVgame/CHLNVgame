﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour {

    public Define.DIRECTION_CANON_SHOT directionShot;

	public int Speed;
	public float timeAction = 0f;
	public int HP;
	public int Damge;
    public int Bonus;

	private int level = 0;

    void Awake()
    {
        if (directionShot == Define.DIRECTION_CANON_SHOT.RIGHT)
        {
            transform.Rotate(0, 0, Define.ANGLE_ROTATE_180);
        }
    }

    // Use this for initialization
    void Start()
    {
		Speed = Attributes.CANON_ATT [level, Attributes.SPEED_CANON];
		HP = Attributes.CANON_ATT[level, Attributes.HP_CANON];
		Damge = Attributes.CANON_ATT[level, Attributes.DAMGE_CANON];
        Bonus = Attributes.CANON_ATT[level, Attributes.BONUS_CANON];


        Health health = GetComponent<Health> ();
		if(health != null)
            health.SeekHealthDamge(HP, Damge, Bonus);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeSinceLevelLoad > timeAction)
            DirectionMove();
    }
    protected void DirectionMove()
    {
        Vector3 targetMove = transform.position;
        targetMove.y -= Speed * Time.deltaTime;
        transform.position = targetMove;
    }
}
