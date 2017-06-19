using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//from Assets.Scripts.MapLevel.MapScroll;
public class Special : MonoBehaviour {

	public int Speed;
	public float timeAction = 0f;
	public int HP;
	public int Damge;

	private int level = 0;
	// Use this for initialization
	void Start()
	{
		Speed = Attributes.SPECIAL_ATT [level, Attributes.SPEED_SPECIAL];
		HP = Attributes.SPECIAL_ATT[level, Attributes.HP_SPECIAL];
		Damge = Attributes.SPECIAL_ATT[level, Attributes.DAMGE_ENEMY];

		Health health = GetComponent<Health> ();
		if(health != null)
			health.SeekHealthDamge (HP, Damge);
	}
	
	// Update is called once per frame
	void Update () {
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
