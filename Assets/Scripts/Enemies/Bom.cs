using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bom : MonoBehaviour {

    public int Speed;
    public float timeAction = 0f;
	public int HP;
	public int Damge;
    public int Bonus;

    private int level = 0;
    // Use this for initialization
    void Start()
    {
		Speed = Attributes.BOM_ATT [level, Attributes.SPEED_BOM];
		HP = Attributes.BOM_ATT[level, Attributes.HP_BOM];
		Damge = Attributes.BOM_ATT[level, Attributes.DAMGE_BOM];
        Bonus = Attributes.BOM_ATT[level, Attributes.BONUS_BOM];

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
