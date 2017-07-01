using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour {
	public float timeAction = 0f;
	public GameObject gunLeft;
	public GameObject gunRight;
	GameObject player;
	public GameObject[] listBulletType;
	public Transform[] listBulletPosistion;
	bool canShoot = false;
	public int Speed;
	protected int HP;
	// Flow move;
	int pointMoveID = 0;
	public PathFollow path;
	public float rotationSpeed;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	// Update is called once per frame
	void Update () {
		/*if (Time.timeSinceLevelLoad <= timeAction)
			return;*/
		if (player != null) {
			RotateToTarget (gunLeft, player);
			RotateToTarget (gunRight, player);
		}
		DirectionMove ();
		if(canShoot)
			StartCoroutine (shoot());
	}
	IEnumerator shoot() {
		canShoot = false;

		for (int i = 0; i < listBulletType.Length; i++) 
		{
			for (int j = 0; j < 3; j++) {

				Instantiate (listBulletType[i], listBulletPosistion[i].position, Quaternion.identity);
				yield return new WaitForSeconds (0.3f);
			}
			yield return new WaitForSeconds (2.2f);
		}

		canShoot = true;
	}
	void RotateToTarget(GameObject obj, GameObject objTarget)
	{
		Vector3 direction = objTarget.transform.position - obj.transform.position;
		float angle = Mathf.Atan2 (direction.y, direction.x) * Mathf.Rad2Deg - Define.ANGLE_ROTATE_90;
		obj.transform.rotation  = Quaternion.AngleAxis (angle, Vector3.forward);
	}

	void DirectionMove()
	{
		float distance = Vector3.Distance (path.path_Objects [pointMoveID].position, transform.position);
		transform.position = Vector3.MoveTowards (transform.position, path.path_Objects [pointMoveID].position, Time.deltaTime * Speed);
		//var rotation = Quaternion.LookRotation (path.path_Objects [pointID].position - transform.position);
		//transform.rotation = Quaternion.Slerp (transform.rotation, rotation, Time.deltaTime * rotationSpeed);

		if (distance < Define.REACH_DISTANCE) {
			if (pointMoveID == 0)
				canShoot = true;
			pointMoveID++;
		}
		if (pointMoveID >= path.path_Objects.Count)
			pointMoveID = 0;
	}
}
