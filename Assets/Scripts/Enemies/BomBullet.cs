using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomBullet : MonoBehaviour {

	public int Speed;
	public float timeAction = 0f;
	public int HP;

	private int level = 0;
	// Use this for initialization
	void Start()
	{
		Speed = Attributes.BOM_BULLET_ATT [level, Attributes.SPEED_BOM_BULLET];
		HP = Attributes.BOM_BULLET_ATT[level, Attributes.HP_BOM_BULLET];
		Health health = GetComponent<Health> ();
		if(health != null)
			health.SetHealth (HP);
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
