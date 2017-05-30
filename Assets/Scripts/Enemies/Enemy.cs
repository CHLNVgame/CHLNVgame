using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	// Properties
	public float timeAction = 0f;

	[Range(1, Attributes.TOTAL_LEVEL_ENEMY)]
	public int levelEnemy = 1;
	public Define.DIRECTION_ENEMIES directionMove;

	[SerializeField] private GameObject[] ListEffectDestroy = null;

	protected Transform tr_Player;
	protected Vector3 targetMove;

	protected float timeCounter;
	protected int Speed;
	protected int HP;
	void Awake() {
	}
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
        Debug.Log(" timeSinceLevelLoad:  " + Time.timeSinceLevelLoad);
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
	public int GetHPEnemy() {
		return HP;
	}
	void OnTriggerEnter2D(Collider2D target) {
		if (target.tag == "DestroyEnemies")
			Destroy (gameObject);
		if (target.tag == "BulletPlayer") {
		//	HP -= Player.Instance.GetAttack();
		//	if(HP<=Define.ZERO)
				Destroy (gameObject);
			int temp = Random.Range (0, ListEffectDestroy.Length);
		//	Debug.Log (" xxxxxxxxxxxxxxxxxxxxxx  temp: "+temp);
		//	Debug.Log (" yyyyyyyyyyyyyyyyyyyyyy  ListEffectDestroy.Length: "+ListEffectDestroy.Length);
			Instantiate (ListEffectDestroy[temp], transform.position, Quaternion.identity);
		}
	}
}
