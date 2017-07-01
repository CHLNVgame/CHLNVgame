using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E6 : Enemy {
	// Use this for initialization
	private float timeChase = 4.0f;
	private bool activeChase = false;

	public GameObject pathFollowPrefab;
	private Transform[] Nodes;
	private int currNode;
	private Vector3 currPossitionNode;

	void Awake()
	{	
		if (directionMove == Define.DIRECTION_ENEMIES.TOP_BOTTOM) {
			//transform.Rotate (0, 0, 180f);
		} else if (directionMove == Define.DIRECTION_ENEMIES.RIGHT_LEFT) {
			//transform.Rotate (0, 0, 90f);
		}
		else if (directionMove == Define.DIRECTION_ENEMIES.LEFT_RIGHT) 
		{
			//transform.Rotate (0,180f,0);
		}
		Speed = Attributes.E6_ATT [levelEnemy - 1, Attributes.SPEED_ENEMY];
		HP    = Attributes.E6_ATT [levelEnemy - 1, Attributes.HP_ENEMY];
		Damge = Attributes.E6_ATT[levelEnemy - 1, Attributes.DAMGE_ENEMY];
	}
	void Start () {
		
		Health health = GetComponent<Health> ();
		if(health != null)
			health.SeekHealthDamge (HP, Damge);
		var player = GameObject.FindGameObjectWithTag ("Player");
		if(player !=null)
			tr_Player = GameObject.FindGameObjectWithTag ("Player").transform;
		activeChase = true;

		GameObject pathFollow = (GameObject)Instantiate (pathFollowPrefab, transform.position, transform.rotation);
		Nodes = new Transform[pathFollowPrefab.transform.childCount];
		for (int i = 0; i < Nodes.Length; i++) {
			Nodes [i] = pathFollow.transform.GetChild (i);
		}
		currNode = 0;
		CheckNode ();
	}

	void CheckNode()
	{
		if(currNode < Nodes.Length)
			currPossitionNode = Nodes [currNode].position;
	}

	// Update is called once per frame
	void PathFollow () {

		if(Vector3.Distance(transform.position, currPossitionNode) <1f)
		{
			currNode ++;
			CheckNode ();
		}

		Vector3 direction = currPossitionNode - transform.position;
		float angle = Mathf.Atan2 (direction.y, direction.x) * Mathf.Rad2Deg - 90f;
		Quaternion rotation = Quaternion.AngleAxis (angle, Vector3.forward);
		transform.rotation = Quaternion.Slerp (transform.rotation, rotation, Speed* Time.deltaTime);
		transform.position += transform.up * Time.deltaTime*Speed*2f;

	}
	
	// Update is called once per frame
	void Update () {
		if (currNode < Nodes.Length)
			PathFollow ();
		else if(tr_Player !=null)
			ChasePlayer ();
	}
		
	void ChasePlayer()
	{
		float distance = Vector3.Distance(tr_Player.position, transform.position);
	//	//Debug.Log (" xxxxxxxxxxxxx  distance: "+distance);
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
