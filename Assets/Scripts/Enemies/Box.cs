using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//from Assets.Scripts.MapLevel.MapScroll;
public class Box : MonoBehaviour {

	public float Speed;
	public float timeAction = 0f;
	public int HP;
	public int Damge;
    public int Bonus;

    private int level = 0;
	bool actived = false;
	// Use this for initialization
	void Start()
	{
		//Speed = Attributes.BOX_ATT [level, Attributes.SPEED_BOX];
		HP = Attributes.BOX_ATT[level, Attributes.HP_BOX];
		Damge = Attributes.BOX_ATT[level, Attributes.DAMGE_BOX];
        Bonus = Attributes.BOX_ATT[level, Attributes.BONUS_BOX];

        Health health = GetComponent<Health> ();
		if(health != null)
            health.SeekHealthDamge(HP, Damge, Bonus);
    }
	
	// Update is called once per frame
	void Update () {
         //   DirectionMove();
    }
    protected void DirectionMove()
    {
        Vector3 targetMove = transform.position;
        targetMove.y -= Speed * Time.deltaTime;
        transform.position = targetMove;
    }
	void OnTriggerEnter2D(Collider2D target)
	{
	//	Debug.Log (target.tag);
		if (target.tag == "DestroyEnemies")
			Destroy (gameObject);
	}
}
